using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IGameFactoryComponent : ICorvidFactoryComponent {
		Game CreateGame (ModSettings modSettings, IApplication app, bool showGame);
	}
}
