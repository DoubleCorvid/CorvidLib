using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultTileFactoryComponent : ITileFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultTileFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Tile CreateTile () {
			return _originalGameFactory.CreateTile ();
		}
	}
}
