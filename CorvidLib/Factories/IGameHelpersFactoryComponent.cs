using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IGameHelpersFactoryComponent : ICorvidFactoryComponent {
		GameHelpers CreateGameHelperInstance ();
	}
}
