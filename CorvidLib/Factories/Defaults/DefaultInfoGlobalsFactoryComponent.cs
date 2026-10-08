using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultInfoGlobalsFactoryComponent : IInfoGlobalsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultInfoGlobalsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public InfoGlobals CreateInfoGlobals () {
			return _originalGameFactory.CreateInfoGlobals ();
		}
	}
}
