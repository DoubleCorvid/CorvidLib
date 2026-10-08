using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface IClientInputFactoryComponent : ICorvidFactoryComponent {
		ClientInput CreateClientInput (IApplication app);
	}
}
