using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultPlayerAIFactoryComponent : IPlayerAIFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultPlayerAIFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Player.PlayerAI CreatePlayerAI () {
			return _originalGameFactory.CreatePlayerAI ();
		}
	}
}
