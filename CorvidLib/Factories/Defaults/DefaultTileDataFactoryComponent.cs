using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultTileDataFactoryComponent : ITileDataFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultTileDataFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TileData CreateTileData (int id) {
			return _originalGameFactory.CreateTileData (id);
		}
	}
}
