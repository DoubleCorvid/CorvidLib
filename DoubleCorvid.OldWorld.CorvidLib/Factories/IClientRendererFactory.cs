using TenCrowns.ClientCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IClientRendererFactory {
	ClientRenderer CreateClientRenderer (IApplication app);
}
