using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IInfoHelpersFactoryComponent : ICorvidFactoryComponent {
		InfoHelpers CreateInfoHelpers (Infos infos);
	}
}
