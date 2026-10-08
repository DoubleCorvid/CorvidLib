using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface IClientUIFactoryComponent : ICorvidFactoryComponent {
		ClientUI CreateClientUI (IApplication app);
	}
}
