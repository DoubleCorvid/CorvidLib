using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ITribeFactoryComponent : ICorvidFactoryComponent {
		Tribe CreateTribe ();
	}
}
