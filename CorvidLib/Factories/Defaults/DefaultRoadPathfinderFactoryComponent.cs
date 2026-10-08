using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultRoadPathfinderFactoryComponent : IRoadPathfinderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultRoadPathfinderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public RoadPathfinder CreateRoadPathfinder (Game game) {
			return _originalGameFactory.CreateRoadPathfinder (game);
		}
	}
}
