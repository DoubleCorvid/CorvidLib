using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IUnitRoleManagerFactoryComponent : ICorvidFactoryComponent {
		Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game);
	}
}
