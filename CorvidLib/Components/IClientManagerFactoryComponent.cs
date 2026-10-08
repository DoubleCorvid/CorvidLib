using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IClientManagerFactoryComponent : ICorvidFactoryComponent {
		ClientManager CreateClientManager (GameInterfaces gameInterfaces);
	}
}
