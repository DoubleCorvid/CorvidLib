using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultTribeFactoryComponent : ITribeFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultTribeFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Tribe CreateTribe () {
			return _originalGameFactory.CreateTribe ();
		}
	}
}
