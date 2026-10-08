using TenCrowns.ClientCore;

namespace CorvidLib.Factories {
	public interface ITechTreeFactoryComponent : ICorvidFactoryComponent {
		TechTree CreateTechTree ();
	}
}
