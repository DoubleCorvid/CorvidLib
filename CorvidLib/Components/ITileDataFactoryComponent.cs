using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ITileDataFactoryComponent : ICorvidFactoryComponent {
		TileData CreateTileData (int id);
	}
}
