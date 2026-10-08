using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientUIFactoryComponent : IClientUIFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientUIFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientUI CreateClientUI (IApplication app) {
			return _originalGameFactory.CreateClientUI (app);
		}
	}
}
