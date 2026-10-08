using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultInfoHelpersFactoryComponent : IInfoHelpersFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultInfoHelpersFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public InfoHelpers CreateInfoHelpers (Infos infos) {
			return _originalGameFactory.CreateInfoHelpers (infos);
		}
	}
}
