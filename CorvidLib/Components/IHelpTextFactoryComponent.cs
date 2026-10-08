using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components {
	public interface IHelpTextFactoryComponent : ICorvidFactoryComponent {
		HelpText CreateHelpText (TextManager textManager);
	}
}
