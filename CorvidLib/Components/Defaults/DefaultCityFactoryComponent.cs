using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultCityFactoryComponent : ICityFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultCityFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public City CreateCity () {
			return _originalGameFactory.CreateCity ();
		}
	}
}
