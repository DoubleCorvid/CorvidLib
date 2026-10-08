using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IClientManagerFactoryComponent : ICorvidFactoryComponent {
		ClientManager CreateClientManager (GameInterfaces gameInterfaces);
	}
}
