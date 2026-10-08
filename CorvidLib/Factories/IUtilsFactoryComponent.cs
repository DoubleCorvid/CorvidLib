using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IUtilsFactoryComponent : ICorvidFactoryComponent {
		Utils CreateUtils ();
	}
}
