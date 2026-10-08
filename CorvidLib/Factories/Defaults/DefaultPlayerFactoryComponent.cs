using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultPlayerFactoryComponent : IPlayerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultPlayerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Player CreatePlayer () {
			return _originalGameFactory.CreatePlayer ();
		}
	}
}
