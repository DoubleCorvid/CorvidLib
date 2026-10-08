using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface IClientInputFactoryComponent : ICorvidFactoryComponent {
		ClientInput CreateClientInput (IApplication app);
	}
}
