using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IUnitAIFactoryComponent : ICorvidFactoryComponent {
		Unit.UnitAI CreateUnitAI ();
	}
}
