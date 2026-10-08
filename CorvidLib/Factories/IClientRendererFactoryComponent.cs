using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface IClientRendererFactoryComponent : ICorvidFactoryComponent {
		ClientRenderer CreateClientRenderer (IApplication app);
	}
}
