using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IUnitAIFactoryComponent : ICorvidFactoryComponent {
		Unit.UnitAI CreateUnitAI ();
	}
}
