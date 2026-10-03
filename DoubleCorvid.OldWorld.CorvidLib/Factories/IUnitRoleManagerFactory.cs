using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories {
	public interface IUnitRoleManagerFactory {
		Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game);
	}
}
