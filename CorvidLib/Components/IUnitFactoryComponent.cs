using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IUnitFactoryComponent : ICorvidFactoryComponent {
		Unit CreateUnit ();
	}
}
