using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultCityFactoryComponent : ICityFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultCityFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public City CreateCity () {
			return _originalGameFactory.CreateCity ();
		}
	}
}
