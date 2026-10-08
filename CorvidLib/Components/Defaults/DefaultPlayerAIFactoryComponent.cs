using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultPlayerAIFactoryComponent : IPlayerAIFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultPlayerAIFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Player.PlayerAI CreatePlayerAI () {
			return _originalGameFactory.CreatePlayerAI ();
		}
	}
}
