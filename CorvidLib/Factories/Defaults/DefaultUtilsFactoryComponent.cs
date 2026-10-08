using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultUtilsFactoryComponent : IUtilsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultUtilsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Utils CreateUtils () {
			return _originalGameFactory.CreateUtils ();
		}
	}
}
