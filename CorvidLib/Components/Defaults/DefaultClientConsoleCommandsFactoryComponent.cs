using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientConsoleCommandsFactoryComponent : IClientConsoleCommandsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientConsoleCommandsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientConsoleCommands CreateClientConsoleCommands (IApplication app) {
			return _originalGameFactory.CreateClientConsoleCommands (app);
		}
	}
}
