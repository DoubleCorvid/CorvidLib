using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IUnitRoleManagerFactoryComponent : ICorvidFactoryComponent {
		Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game);
	}
}
