using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientInputFactoryComponent : IClientInputFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientInputFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientInput CreateClientInput (IApplication app) {
			return _originalGameFactory.CreateClientInput (app);
		}
	}
}
