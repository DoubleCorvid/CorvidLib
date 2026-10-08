using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface IClientRendererFactoryComponent : ICorvidFactoryComponent {
		ClientRenderer CreateClientRenderer (IApplication app);
	}
}
