using TenCrowns.ClientCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IClientSelectionFactory {
	ClientSelection CreateClientSelection (IApplication app);
}
