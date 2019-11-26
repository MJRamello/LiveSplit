using LiveSplit;
using LiveSplit.Model;
using LiveSplit.UI.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

[assembly: ComponentFactory(typeof(ChangableRoutesFactory))]

namespace LiveSplit
{
    public class ChangableRoutesFactory : IComponentFactory
    {
        #region Public Properties

        public ComponentCategory Category => ComponentCategory.Control;
        public string ComponentName => "Changable Routes";
        public string Description => "Allows a runner to change routes on the fly during a run";
        public string UpdateName => this.ComponentName;
        public string UpdateURL { get; }
        public Version Version { get; }
        public string XMLURL { get; }

        #endregion Public Properties

        #region Public Methods

        public IComponent Create(LiveSplitState state) => new ChangableRoutesComponent(state);

        #endregion Public Methods
    }
}