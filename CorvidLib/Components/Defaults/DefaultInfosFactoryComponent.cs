using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultInfosFactoryComponent : IInfosFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultInfosFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Infos CreateInfos (ModSettings modSettings) {
			return _originalGameFactory.CreateInfos (modSettings);
		}
	}
}
