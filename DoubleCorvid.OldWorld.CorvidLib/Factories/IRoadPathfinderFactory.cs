using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IRoadPathfinderFactory {
	RoadPathfinder CreateRoadPathfinder (Game game);
}
