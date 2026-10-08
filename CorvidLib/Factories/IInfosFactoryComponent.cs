using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IInfosFactoryComponent : ICorvidFactoryComponent {
		Infos CreateInfos (ModSettings modSettings);
	}
}
