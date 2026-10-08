using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultTileFactoryComponent : ITileFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultTileFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Tile CreateTile () {
			return _originalGameFactory.CreateTile ();
		}
	}
}
