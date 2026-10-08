using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IRoadPathfinderFactoryComponent : ICorvidFactoryComponent {
		RoadPathfinder CreateRoadPathfinder (Game game);
	}
}
