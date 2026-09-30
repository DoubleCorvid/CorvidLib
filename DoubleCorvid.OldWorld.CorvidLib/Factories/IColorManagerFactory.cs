using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IColorManagerFactory {
	ColorManager CreateColorManager (Infos infos, TextManager textManager);
}
