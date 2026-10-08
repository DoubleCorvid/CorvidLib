using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultClientInputFactoryComponent : IClientInputFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultClientInputFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientInput CreateClientInput (IApplication app) {
			return _originalGameFactory.CreateClientInput (app);
		}
	}
}
