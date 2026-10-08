using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientSelectionFactoryComponent : IClientSelectionFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientSelectionFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientSelection CreateClientSelection (IApplication app) {
			return _originalGameFactory.CreateClientSelection (app);
		}
	}
}
