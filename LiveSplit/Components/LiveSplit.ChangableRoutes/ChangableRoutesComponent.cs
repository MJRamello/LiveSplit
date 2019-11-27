using LiveSplit.Model;
using LiveSplit.Model.Input;
using LiveSplit.UI;
using LiveSplit.UI.Components;

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Windows.Input;
using System.Xml;

namespace LiveSplit
{
    public class ChangableRoutesComponent : IComponent
    {
        #region Public Constructors

        public ChangableRoutesComponent(LiveSplitState state)
        {
            Settings = new ChangableRoutesSettings(state);
            Settings.enableApperance.PropertyChanged += EnableApperance_PropertyChanged;
            InternalComponent = new InfoTextComponent("Current Route", "")
            {
                AlternateNameText = new[]
                {
                    "Route",
                    "Rte."
                }
            };
        }

        #endregion Public Constructors

        #region Protected Properties

        protected InfoTextComponent InternalComponent { get; set; }

        #endregion Protected Properties

        #region Public Properties

        public string ComponentName => "Changable Routes";

        public IDictionary<string, Action> ContextMenuControls => null;

        public float HorizontalWidth { get; set; }

        public float MinimumHeight { get; set; }

        public float MinimumWidth { get; set; }

        public float PaddingBottom { get; set; }

        public float PaddingLeft { get; set; }

        public float PaddingRight { get; set; }

        public float PaddingTop { get; set; }

        public ChangableRoutesSettings Settings { get; set; }

        public float VerticalHeight { get; set; }

        #endregion Public Properties

        #region Private Methods

        private void EnableApperance_PropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
        {
            HorizontalWidth = Settings.enableApperance.Value ? InternalComponent.HorizontalWidth : 0;
            MinimumHeight = Settings.enableApperance.Value ? InternalComponent.MinimumHeight : 0;
            MinimumWidth = Settings.enableApperance.Value ? InternalComponent.MinimumWidth : 0;
            PaddingBottom = Settings.enableApperance.Value ? InternalComponent.PaddingBottom : 0;
            PaddingLeft = Settings.enableApperance.Value ? InternalComponent.PaddingLeft : 0;
            PaddingRight = Settings.enableApperance.Value ? InternalComponent.PaddingRight : 0;
            PaddingTop = Settings.enableApperance.Value ? InternalComponent.PaddingTop : 0;
            VerticalHeight = Settings.enableApperance.Value ? InternalComponent.VerticalHeight : 0;
        }

        #endregion Private Methods

        #region Public Methods

        public void Dispose()
        {
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
            if (Settings.enableApperance.Value)
                InternalComponent.DrawHorizontal(g, state, height, clipRegion);
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
            if (Settings.enableApperance.Value)
                InternalComponent.DrawVertical(g, state, width, clipRegion);
        }

        public XmlNode GetSettings(XmlDocument document) => Settings.GetSettings(document);

        public System.Windows.Forms.Control GetSettingsControl(LayoutMode mode) => Settings;

        public void SetSettings(XmlNode settings) => Settings.SetSettings(settings);

        public void Update(IInvalidator invalidator, LiveSplitState state, float width, float height, LayoutMode mode)
        {
        }

        #endregion Public Methods
    }
}