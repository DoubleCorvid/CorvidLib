using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultPlayerFactoryComponent : IPlayerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultPlayerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Player CreatePlayer () {
			return _originalGameFactory.CreatePlayer ();
		}
	}
}
