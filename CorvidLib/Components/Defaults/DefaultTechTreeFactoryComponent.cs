using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultTechTreeFactoryComponent : ITechTreeFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultTechTreeFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TechTree CreateTechTree () {
			return _originalGameFactory.CreateTechTree ();
		}
	}
}
