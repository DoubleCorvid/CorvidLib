using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultInfoGlobalsFactoryComponent : IInfoGlobalsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultInfoGlobalsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public InfoGlobals CreateInfoGlobals () {
			return _originalGameFactory.CreateInfoGlobals ();
		}
	}
}
