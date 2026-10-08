using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IMapBuilderFactoryComponent : ICorvidFactoryComponent {
		MapBuilder CreateMapBuilder ();
	}
}
