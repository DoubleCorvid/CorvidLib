using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface IClientSelectionFactoryComponent : ICorvidFactoryComponent {
		ClientSelection CreateClientSelection (IApplication app);
	}
}
