using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ICityFactoryComponent : ICorvidFactoryComponent {
		City CreateCity ();
	}
}
