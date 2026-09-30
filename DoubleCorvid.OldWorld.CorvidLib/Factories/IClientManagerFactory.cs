using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IClientManagerFactory {
	ClientManager CreateClientManager (GameInterfaces gameInterfaces);
}
