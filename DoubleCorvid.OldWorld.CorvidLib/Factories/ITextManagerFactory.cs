using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories {
	public interface ITextManagerFactory {
		TextManager CreateTextManager (Infos infos, LanguageType languageType);
	}	
}
