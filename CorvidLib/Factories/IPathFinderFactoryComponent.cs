using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IPathFinderFactoryComponent : ICorvidFactoryComponent {
		PathFinder CreatePathfinder ();
	}
}
