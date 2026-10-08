using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ICityFactoryComponent : ICorvidFactoryComponent {
		City CreateCity ();
	}
}
