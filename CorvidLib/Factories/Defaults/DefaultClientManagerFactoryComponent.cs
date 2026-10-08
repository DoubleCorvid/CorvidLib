using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultClientManagerFactoryComponent : IClientManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultClientManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientManager CreateClientManager (GameInterfaces gameInterfaces) {
			return _originalGameFactory.CreateClientManager (gameInterfaces);
		}
	}
}
