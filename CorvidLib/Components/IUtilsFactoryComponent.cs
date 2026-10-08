using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IUtilsFactoryComponent : ICorvidFactoryComponent {
		Utils CreateUtils ();
	}
}
