using TenCrowns.ClientCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IClientUIFactory {
	ClientUI CreateClientUI (IApplication app);
}
