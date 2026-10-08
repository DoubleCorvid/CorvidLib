using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories {
	public interface IColorManagerFactoryComponent : ICorvidFactoryComponent {
		ColorManager CreateColorManager (Infos infos, TextManager textManager);
	}
}
