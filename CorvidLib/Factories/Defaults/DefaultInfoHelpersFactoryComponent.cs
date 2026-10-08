using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultInfoHelpersFactoryComponent : IInfoHelpersFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultInfoHelpersFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public InfoHelpers CreateInfoHelpers (Infos infos) {
			return _originalGameFactory.CreateInfoHelpers (infos);
		}
	}
}
