using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultTribeFactoryComponent : ITribeFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultTribeFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Tribe CreateTribe () {
			return _originalGameFactory.CreateTribe ();
		}
	}
}
