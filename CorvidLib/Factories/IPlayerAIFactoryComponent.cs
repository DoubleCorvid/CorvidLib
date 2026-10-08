using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IPlayerAIFactoryComponent : ICorvidFactoryComponent {
		Player.PlayerAI CreatePlayerAI ();
	}
}
