using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IPlayerFactoryComponent : ICorvidFactoryComponent {
		Player CreatePlayer ();
	}
}
