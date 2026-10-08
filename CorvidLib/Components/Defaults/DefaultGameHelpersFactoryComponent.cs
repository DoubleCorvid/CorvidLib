using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultGameHelpersFactoryComponent : IGameHelpersFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultGameHelpersFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public GameHelpers CreateGameHelperInstance () {
			return _originalGameFactory.CreateGameHelperInstance ();
		}
	}
}
