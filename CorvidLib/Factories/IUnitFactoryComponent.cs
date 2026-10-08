using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IUnitFactoryComponent : ICorvidFactoryComponent {
		Unit CreateUnit ();
	}
}
