using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultUtilsFactoryComponent : IUtilsFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultUtilsFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Utils CreateUtils () {
			return _originalGameFactory.CreateUtils ();
		}
	}
}
