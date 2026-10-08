using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface IClientConsoleCommandsFactoryComponent : ICorvidFactoryComponent {
		ClientConsoleCommands CreateClientConsoleCommands (IApplication app);
	}
}
