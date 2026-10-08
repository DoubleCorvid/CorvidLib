using TenCrowns.ClientCore;

namespace CorvidLib.Components {
	public interface ITechTreeFactoryComponent : ICorvidFactoryComponent {
		TechTree CreateTechTree ();
	}
}
