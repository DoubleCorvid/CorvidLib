using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IGameHelpersFactoryComponent : ICorvidFactoryComponent {
		GameHelpers CreateGameHelperInstance ();
	}
}
