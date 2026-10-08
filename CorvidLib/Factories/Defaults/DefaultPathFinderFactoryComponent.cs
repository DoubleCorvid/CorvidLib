using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultPathFinderFactoryComponent : IPathFinderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultPathFinderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public PathFinder CreatePathfinder () {
			return _originalGameFactory.CreatePathfinder ();
		}
	}
}
