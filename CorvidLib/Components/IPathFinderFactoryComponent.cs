using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IPathFinderFactoryComponent : ICorvidFactoryComponent {
		PathFinder CreatePathfinder ();
	}
}
