using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IGameFactoryComponent : ICorvidFactoryComponent {
		Game CreateGame (ModSettings modSettings, IApplication app, bool showGame);
	}
}
