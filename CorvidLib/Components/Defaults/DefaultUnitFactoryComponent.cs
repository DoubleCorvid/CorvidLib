using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultUnitFactoryComponent : IUnitFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultUnitFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Unit CreateUnit () {
			return _originalGameFactory.CreateUnit ();
		}
	}
}
