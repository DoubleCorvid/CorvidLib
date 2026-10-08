using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultClientConsoleCommandsFactoryComponent : IClientConsoleCommandsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultClientConsoleCommandsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientConsoleCommands CreateClientConsoleCommands (IApplication app) {
			return _originalGameFactory.CreateClientConsoleCommands (app);
		}
	}
}
