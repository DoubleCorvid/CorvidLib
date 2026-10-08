using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IMapBuilderFactoryComponent : ICorvidFactoryComponent {
		MapBuilder CreateMapBuilder ();
	}
}
