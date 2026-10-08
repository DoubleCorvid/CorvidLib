using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IRoadPathfinderFactoryComponent : ICorvidFactoryComponent {
		RoadPathfinder CreateRoadPathfinder (Game game);
	}
}
