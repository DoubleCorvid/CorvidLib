using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultUnitRoleManagerFactoryComponent : IUnitRoleManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultUnitRoleManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game) {
			return _originalGameFactory.CreateUnitRoleManager (game);
		}
	}
}
