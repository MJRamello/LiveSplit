using LiveSplit.Model;
using LiveSplit.Model.Comparisons;
using LiveSplit.Model.Input;
using LiveSplit.Model.RunFactories;
using LiveSplit.UI;

using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;
using System.Xml;

using input = System.Windows.Input;

namespace LiveSplit
{
    public partial class ChangableRoutesSettings : UserControl
    {
        #region Private Fields

        private readonly LiveSplitState _state;

        #endregion Private Fields

        #region Public Constructors

        public ChangableRoutesSettings(LiveSplitState state)
        {
            InitializeComponent();
            this._state = state;
            Routes = new BindingList<Route>();
            this.dgvRoutes.AutoGenerateColumns = false;
            this.dgvRoutes.DataSource = Routes;

            var titleColumn = this.dgvRoutes.Columns[0];
            titleColumn.DataPropertyName = nameof(Route.RouteName);
            var pathColumn = this.dgvRoutes.Columns[1];
            pathColumn.DataPropertyName = nameof(Route.Path);

            lblNextRoute.Text = $"Next Route: {NextRouteHotkey.ToString()}";
            lblPreviousRoute.Text = $"Previous Route: {PreviousRouteHotkey.ToString()}";

            Hook = new CompositeHook();
            Hook.KeyOrButtonPressed += hook_KeyOrButtonPressed;
            var hotkeyProfile = state.Settings.HotkeyProfiles[state.CurrentHotkeyProfile];
            RegisterHotkey(Hook, NextRouteHotkey, hotkeyProfile.GlobalHotkeysEnabled);
            RegisterHotkey(Hook, PreviousRouteHotkey, hotkeyProfile.GlobalHotkeysEnabled);

            grpAppearance.DataBindings.Add(new Binding("Enabled", enableApperance, "Value"));
            grpHotkeys.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
            grpRoutes.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
            chkShowLabel.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
        }

        #endregion Public Constructors

        #region Private Properties

        private int routeIndex { get; set; }
        private BindingList<Route> Routes { get; set; }

        #endregion Private Properties

        #region Protected Properties

        protected CompositeHook Hook { get; private set; }

        #endregion Protected Properties

        #region Public Properties

        public IsEnabled enableApperance { get; set; } = new IsEnabled();

        public KeyOrButton NextRouteHotkey { get; set; } = new KeyOrButton(Keys.NumPad6);
        public KeyOrButton PreviousRouteHotkey { get; set; } = new KeyOrButton(Keys.NumPad4);

        public bool RoutesEnabled { get; private set; }

        #endregion Public Properties

        #region Private Methods

        private void btnAddRoute_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "LiveSplit Split files (*.lss)|*.lss";
            openFileDialog1.Multiselect = true;

            if (_state.Settings.RecentSplits.Count > 0)
            {
                openFileDialog1.InitialDirectory
                    = System.IO.Path.GetDirectoryName(_state.Settings.RecentSplits.Last().Path);
            }

            if (openFileDialog1.ShowDialog() != DialogResult.Cancel)
            {
                foreach (var filename in openFileDialog1.FileNames)
                {
                    // if the binding list doesn't have this route yet
                    if (Routes.FirstOrDefault(r => r.Path == filename) == default(Route))
                    {
                        Routes.Add(new Route("", filename));
                    }
                }
            }
        }

        private void btnNextRoute_Click(object sender, EventArgs e)
        {
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
        }

        private void chkShowLabel_CheckedChanged(object sender, EventArgs e)
        {
            grpAppearance.Enabled = chkShowLabel.Checked;
        }

        private void chkUseRoutes_CheckedChanged(object sender, EventArgs e)
        {
            RoutesEnabled = chkUseRoutes.Checked;
            enableApperance.Value = RoutesEnabled && chkShowLabel.Checked;
        }

        private void hook_KeyOrButtonPressed(object sender, KeyOrButton value)
        {
            if (value == NextRouteHotkey)
                MessageBox.Show("Next");
            else if (value == PreviousRouteHotkey)
                MessageBox.Show("Previous");
        }

        private void RegisterHotkey(CompositeHook hook, KeyOrButton key, bool deactivateForOtherPrograms)
        {
            hook.RegisterHotKey(key);
            if (deactivateForOtherPrograms && key.IsKey)
            {
                var args = new KeyEventArgs(key.Key);
                var modifiers = (args.Alt ? input.ModifierKeys.Alt : input.ModifierKeys.None)
                    | (args.Shift ? input.ModifierKeys.Shift : input.ModifierKeys.None)
                    | (args.Control ? input.ModifierKeys.Control : input.ModifierKeys.None);
                HotkeyHook.Instance.RegisterHotKey(modifiers, args.KeyCode);
            }
        }

        #endregion Private Methods

        #region Public Methods

        public XmlNode GetSettings(XmlDocument doc)
        {
            var settingsNode = doc.CreateElement("Settings");

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "Version", Assembly.GetExecutingAssembly().GetName().Version.ToString(3)));

            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "NextRouteHotkey", NextRouteHotkey));
            settingsNode.AppendChild(SettingsHelper.ToElement(doc, "PreviousRouteHotkey", PreviousRouteHotkey));

            var routesNode = doc.CreateElement("Routes");
            foreach (var route in Routes)
            {
                var node = doc.CreateElement("Route");
                node.SetAttribute("Name", route.RouteName);
                node.SetAttribute("Path", route.Path);
                node.SetAttribute("Game", route.GameName);
                node.SetAttribute("Category", route.CategoryName);
                routesNode.AppendChild(node);
            }
            settingsNode.AppendChild(routesNode);
            return settingsNode;
        }

        public void SetSettings(XmlNode settings)
        {
        }

        #endregion Public Methods
    }

    public class IsEnabled : INotifyPropertyChanged
    {
        #region Private Fields

        private bool _value;

        #endregion Private Fields

        #region Public Events

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion Public Events

        #region Public Properties

        public bool Value
        {
            get => _value;
            set {
                _value = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Value)));
            }
        }

        #endregion Public Properties
    }

    public class Route
    {
        #region Public Constructors

        public Route(string path, string routeName)
        {
            Path = path;
            RouteName = routeName;
            IRun run;

            using (var stream = File.OpenRead(Path))
            {
                var factory = new StandardFormatsRunFactory();
                factory.Stream = stream;
                factory.FilePath = Path;

                run = factory.Create(new StandardComparisonGeneratorsFactory());
            }
            GameName = run.GameName;
            CategoryName = run.CategoryName;
        }

        #endregion Public Constructors

        #region Public Properties

        public string CategoryName { get; }
        public string GameName { get; }
        public string Path { get; }
        public string RouteName { get; }

        #endregion Public Properties
    }
}