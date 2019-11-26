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

        public ChangableRoutesSettings Settings { get; set; }
        public float HorizontalWidth => InternalComponent.HorizontalWidth;
        public float MinimumHeight => InternalComponent.MinimumHeight;
        public float MinimumWidth => InternalComponent.MinimumWidth;
        public float PaddingBottom => InternalComponent.PaddingBottom;
        public float PaddingLeft => InternalComponent.PaddingLeft;
        public float PaddingRight => InternalComponent.PaddingRight;
        public float PaddingTop => InternalComponent.PaddingTop;
        public float VerticalHeight => InternalComponent.VerticalHeight;

        #endregion Public Properties

        #region Public Methods

        public void Dispose()
        {
        }

        public void DrawHorizontal(Graphics g, LiveSplitState state, float height, Region clipRegion)
        {
        }

        public void DrawVertical(Graphics g, LiveSplitState state, float width, Region clipRegion)
        {
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