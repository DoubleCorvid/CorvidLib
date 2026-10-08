using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IPlayerAIFactoryComponent : ICorvidFactoryComponent {
		Player.PlayerAI CreatePlayerAI ();
	}
}
