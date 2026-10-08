using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface IClientSelectionFactoryComponent : ICorvidFactoryComponent {
		ClientSelection CreateClientSelection (IApplication app);
	}
}
