using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components {
	public interface IColorManagerFactoryComponent : ICorvidFactoryComponent {
		ColorManager CreateColorManager (Infos infos, TextManager textManager);
	}
}
