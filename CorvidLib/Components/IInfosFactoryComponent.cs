using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IInfosFactoryComponent : ICorvidFactoryComponent {
		Infos CreateInfos (ModSettings modSettings);
	}
}
