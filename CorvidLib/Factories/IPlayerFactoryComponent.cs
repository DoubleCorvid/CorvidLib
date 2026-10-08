using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IPlayerFactoryComponent : ICorvidFactoryComponent {
		Player CreatePlayer ();
	}
}
