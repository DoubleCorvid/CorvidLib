using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultInfosFactoryComponent : IInfosFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultInfosFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Infos CreateInfos (ModSettings modSettings) {
			return _originalGameFactory.CreateInfos (modSettings);
		}
	}
}
