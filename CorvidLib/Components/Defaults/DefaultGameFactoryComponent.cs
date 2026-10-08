using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultGameFactoryComponent : IGameFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultGameFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Game CreateGame (ModSettings modSettings, IApplication app, bool showGame) {
			return _originalGameFactory.CreateGame (modSettings, app, showGame);
		}
	}
}
