using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultClientRendererFactoryComponent : IClientRendererFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultClientRendererFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ClientRenderer CreateClientRenderer (IApplication app) {
			return _originalGameFactory.CreateClientRenderer (app);
		}
	}
}
