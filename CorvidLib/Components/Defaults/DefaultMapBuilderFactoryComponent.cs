using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultMapBuilderFactoryComponent : IMapBuilderFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultMapBuilderFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public MapBuilder CreateMapBuilder () {
			return _originalGameFactory.CreateMapBuilder ();
		}
	}
}
