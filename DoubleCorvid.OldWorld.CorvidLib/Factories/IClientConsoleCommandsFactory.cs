using TenCrowns.ClientCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories {
	public interface IClientConsoleCommandsFactory {
		ClientConsoleCommands CreateClientConsoleCommands (IApplication app);
	}	
}
