using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface IClientUIFactoryComponent : ICorvidFactoryComponent {
		ClientUI CreateClientUI (IApplication app);
	}
}
