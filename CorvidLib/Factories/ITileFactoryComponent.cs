using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ITileFactoryComponent : ICorvidFactoryComponent {
		Tile CreateTile ();
	}
}
