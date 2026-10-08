using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientManagerFactoryComponent : IClientManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientManager CreateClientManager (GameInterfaces gameInterfaces) {
			return _originalGameFactory.CreateClientManager (gameInterfaces);
		}
	}
}
