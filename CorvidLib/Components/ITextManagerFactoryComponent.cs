using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components {
	public interface ITextManagerFactoryComponent : ICorvidFactoryComponent {
		TextManager CreateTextManager (Infos infos, LanguageType languageType);
	}
}
