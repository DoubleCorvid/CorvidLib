using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultMapBuilderFactoryComponent : IMapBuilderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultMapBuilderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public MapBuilder CreateMapBuilder () {
			return _originalGameFactory.CreateMapBuilder ();
		}
	}
}
