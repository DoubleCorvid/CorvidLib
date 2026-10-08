using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ITileDataFactoryComponent : ICorvidFactoryComponent {
		TileData CreateTileData (int id);
	}
}
