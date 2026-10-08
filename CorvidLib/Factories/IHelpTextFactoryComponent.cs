using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories {
	public interface IHelpTextFactoryComponent : ICorvidFactoryComponent {
		HelpText CreateHelpText (TextManager textManager);
	}
}
