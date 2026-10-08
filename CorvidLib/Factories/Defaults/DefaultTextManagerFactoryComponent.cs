using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories.Defaults {
	public class DefaultTextManagerFactoryComponent : ITextManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultTextManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TextManager CreateTextManager (Infos infos, LanguageType languageType) {
			return _originalGameFactory.CreateTextManager (infos, languageType);
		}
	}
}
