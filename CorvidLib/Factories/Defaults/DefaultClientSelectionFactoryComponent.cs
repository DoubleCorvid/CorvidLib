using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultClientSelectionFactoryComponent : IClientSelectionFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultClientSelectionFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientSelection CreateClientSelection (IApplication app) {
			return _originalGameFactory.CreateClientSelection (app);
		}
	}
}
