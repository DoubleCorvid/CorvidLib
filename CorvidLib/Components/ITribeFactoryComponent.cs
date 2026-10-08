using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ITribeFactoryComponent : ICorvidFactoryComponent {
		Tribe CreateTribe ();
	}
}
