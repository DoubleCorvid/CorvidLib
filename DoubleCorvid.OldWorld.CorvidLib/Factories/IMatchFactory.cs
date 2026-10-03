using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories {
	public interface IMatchFactory {
		Game CreateMatch (ModSettings modSettings, IApplication application, bool showGame);
	}	
}
