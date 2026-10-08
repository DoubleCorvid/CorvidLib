using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultPathFinderFactoryComponent : IPathFinderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultPathFinderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public PathFinder CreatePathfinder () {
			return _originalGameFactory.CreatePathfinder ();
		}
	}
}
