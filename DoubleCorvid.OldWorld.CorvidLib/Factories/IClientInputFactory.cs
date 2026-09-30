using TenCrowns.ClientCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IClientInputFactory {
	ClientInput CreateClientInput (IApplication app);
}
