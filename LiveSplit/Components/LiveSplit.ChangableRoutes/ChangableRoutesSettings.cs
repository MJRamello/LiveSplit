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

        private BindingList<string> Categories = new BindingList<string>();
        private BindingList<Route> CurrentCategoryRoutes = new BindingList<Route>();
        private BindingList<string> Games = new BindingList<string>();
        private CompositeHook Hook = new CompositeHook();
        private BindingList<Route> Routes = new BindingList<Route>();

        private bool RoutesEnabled;

        #endregion Private Fields

        #region Public Constructors

        public ChangableRoutesSettings(LiveSplitState state)
        {
            InitializeComponent();
            this._state = state;
            setUpHotkeys();
            setUpControls();

            Routes.ListChanged += RoutesChanged;
            foreach (var route in Routes)
            {
                if (!this.cmbGame.Items.Contains(route.GameName))
                {
                    cmbGame.Items.Add(route.GameName);
                }
            }
        }

        #endregion Public Constructors

        #region Public Properties

        public IsEnabled enableApperance { get; set; } = new IsEnabled();

        public KeyOrButton NextRouteHotkey { get; set; } = new KeyOrButton(Keys.NumPad9);

        public KeyOrButton PreviousRouteHotkey { get; set; } = new KeyOrButton(Keys.NumPad7);

        #endregion Public Properties

        #region Private Methods

        private void AddRoute(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "LiveSplit Split files (*.lss)|*.lss";
            openFileDialog1.Multiselect = true;

            if (_state.Settings.RecentSplits.Count > 0)
            {
                openFileDialog1.InitialDirectory
                    = System.IO.Path.GetDirectoryName(_state.Settings.RecentSplits.Last().Path);
            }
            openFileDialog1.FileName = "";

            if (openFileDialog1.ShowDialog() == DialogResult.Cancel)
            {
                return;
            }

            foreach (var filename in openFileDialog1.FileNames)
            {
                // if the binding list doesn't have this route yet
                if (Routes.FirstOrDefault(r => r.Path == filename) == default(Route))
                {
                    Routes.Add(new Route(filename, ""));
                }
            }

            var lastRouteAdded = Routes.Where(x => x.Path == openFileDialog1.FileNames.Last()).FirstOrDefault();
            cmbGame.SelectedItem = null;
            cmbGame.SelectedItem = Games.Where(x => x == lastRouteAdded.GameName).FirstOrDefault();
            cmbCategory.SelectedItem = null;
            cmbCategory.SelectedItem = Categories.Where(x => x == lastRouteAdded.CategoryName).FirstOrDefault();
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
            enableApperance.Value = RoutesEnabled && chkShowLabel.Checked;
        }

        private void chkUseRoutes_CheckedChanged(object sender, EventArgs e)
        {
            RoutesEnabled = chkUseRoutes.Checked;
            enableApperance.Value = RoutesEnabled && chkShowLabel.Checked;
        }

        private void cmbCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCategory.SelectedItem is null)
            {
                CurrentCategoryRoutes.Clear();
                return;
            }
            var categoryName = cmbCategory.SelectedItem.ToString();
            var gameName = cmbGame.SelectedItem.ToString();
            CurrentCategoryRoutes.ClearAndAddRange(Routes.Where(x => x.GameName == gameName && x.CategoryName == categoryName));
        }

        private void cmbGame_SelectedIndexChanged(object sender, EventArgs e)
        {
            CurrentCategoryRoutes.Clear();
            if (cmbGame.SelectedItem is null)
            {
                cmbCategory.Enabled = false;
                return;
            }
            Categories.ClearAndAddRange(Routes.Where(x => x.GameName == cmbGame.SelectedItem.ToString()).Select(x => x.CategoryName));
            cmbCategory.Enabled = true;
        }

        private void ColorButtonClick(object sender, EventArgs e)
        {
            SettingsHelper.ColorButtonClick((Button)sender, this);
        }

        private void dgvRoutes_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvRoutes.CurrentCell.ReadOnly = false;
        }

        private void dgvRoutes_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
        }

        private void hook_KeyOrButtonPressed(object sender, KeyOrButton value)
        {
            if (value == NextRouteHotkey)
            {
                var oldRun = _state.Run;
                var routes = Routes.Where(x => x.GameName == oldRun.GameName && x.CategoryName == oldRun.CategoryName).ToList();
                var currentRoute = routes.Where(x => x.Path == oldRun.FilePath).First();
                var index = routes.IndexOf(currentRoute);

                var nextIndex = index == routes.Count - 1 ? 0 : index + 1;

                _state.Run = routes[nextIndex].ToRun();

                var oldRunSegments = oldRun.Count;
                var newRunSegments = _state.Run.Count;

                for (int i = 0; i < Math.Min(oldRunSegments, newRunSegments); i++)
                {
                    _state.Run[i].SplitTime = oldRun[i].SplitTime;
                }
            }
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

        private void setUpControls()
        {
            // DataGridView dgvRoutes
            this.dgvRoutes.AutoGenerateColumns = false;
            dgvRoutes.DataSource = CurrentCategoryRoutes;
            colRouteName.DataPropertyName = nameof(Route.RouteName);
            colRouteName.ReadOnly = false;
            colPath.DataPropertyName = nameof(Route.Path);

            //Todo: Add hotkey chooser from settings window

            lblNextRoute.Text = $"Next Route: {NextRouteHotkey.ToString()}";
            lblPreviousRoute.Text = $"Previous Route: {PreviousRouteHotkey.ToString()}";

            // Enable and disable based on settings
            grpAppearance.DataBindings.Add(new Binding("Enabled", enableApperance, "Value"));
            grpHotkeys.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
            grpRoutes.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
            chkShowLabel.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));
            btnAddRoute.DataBindings.Add(new Binding("Enabled", chkUseRoutes, "Checked"));

            // Wire up combo boxes
            cmbGame.DataSource = Games;
            cmbCategory.DataSource = Categories;
        }

        private void setUpHotkeys()
        {
            Hook.KeyOrButtonPressed += hook_KeyOrButtonPressed;
            var hotkeyProfile = _state.Settings.HotkeyProfiles[_state.CurrentHotkeyProfile];
            RegisterHotkey(Hook, NextRouteHotkey, hotkeyProfile.GlobalHotkeysEnabled);
            RegisterHotkey(Hook, PreviousRouteHotkey, hotkeyProfile.GlobalHotkeysEnabled);
        }

        #endregion Private Methods

        #region Protected Methods

        protected void RoutesChanged(object sender, ListChangedEventArgs e)
        {
            if (e.ListChangedType == ListChangedType.ItemAdded)
            {
                if (!Games.Contains(Routes[e.NewIndex].GameName))
                { Games.Add(Routes[e.NewIndex].GameName); }
            }
        }

        #endregion Protected Methods

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
            var run = GetRun(path);

            GameName = run.GameName;
            CategoryName = run.CategoryName;
        }

        #endregion Public Constructors

        #region Public Properties

        public string CategoryName { get; }

        public string GameName { get; }

        public string Path { get; }

        public string RouteName { get; set; }

        #endregion Public Properties

        #region Private Methods

        private IRun GetRun(string path)
        {
            using (var stream = File.OpenRead(Path))
            {
                var factory = new StandardFormatsRunFactory();
                factory.Stream = stream;
                factory.FilePath = Path;

                return factory.Create(new StandardComparisonGeneratorsFactory());
            }
        }

        #endregion Private Methods

        #region Public Methods

        public IRun ToRun() => GetRun(Path);

        #endregion Public Methods
    }
}