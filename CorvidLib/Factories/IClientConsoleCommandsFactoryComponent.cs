using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface IClientConsoleCommandsFactoryComponent : ICorvidFactoryComponent {
		ClientConsoleCommands CreateClientConsoleCommands (IApplication app);
	}
}
