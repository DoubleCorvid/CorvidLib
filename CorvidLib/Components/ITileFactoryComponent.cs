using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ITileFactoryComponent : ICorvidFactoryComponent {
		Tile CreateTile ();
	}
}
