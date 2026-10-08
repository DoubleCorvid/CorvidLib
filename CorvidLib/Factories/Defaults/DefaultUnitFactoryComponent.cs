using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultUnitFactoryComponent : IUnitFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultUnitFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Unit CreateUnit () {
			return _originalGameFactory.CreateUnit ();
		}
	}
}
