using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories {
	public interface ITextManagerFactoryComponent : ICorvidFactoryComponent {
		TextManager CreateTextManager (Infos infos, LanguageType languageType);
	}
}
