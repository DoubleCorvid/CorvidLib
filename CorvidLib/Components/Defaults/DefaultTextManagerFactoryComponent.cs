using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components.Defaults {
	public class DefaultTextManagerFactoryComponent : ITextManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultTextManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TextManager CreateTextManager (Infos infos, LanguageType languageType) {
			return _originalGameFactory.CreateTextManager (infos, languageType);
		}
	}
}
