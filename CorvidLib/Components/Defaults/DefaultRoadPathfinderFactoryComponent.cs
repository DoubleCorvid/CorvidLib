using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultRoadPathfinderFactoryComponent : IRoadPathfinderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultRoadPathfinderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public RoadPathfinder CreateRoadPathfinder (Game game) {
			return _originalGameFactory.CreateRoadPathfinder (game);
		}
	}
}
