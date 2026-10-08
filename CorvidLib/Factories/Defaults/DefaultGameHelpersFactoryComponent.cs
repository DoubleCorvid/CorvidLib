using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultGameHelpersFactoryComponent : IGameHelpersFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultGameHelpersFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public GameHelpers CreateGameHelperInstance () {
			return _originalGameFactory.CreateGameHelperInstance ();
		}
	}
}
