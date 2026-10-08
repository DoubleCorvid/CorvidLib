using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IInfoHelpersFactoryComponent : ICorvidFactoryComponent {
		InfoHelpers CreateInfoHelpers (Infos infos);
	}
}
