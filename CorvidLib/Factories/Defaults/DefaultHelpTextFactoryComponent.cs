using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories.Defaults {
	public class DefaultHelpTextFactoryComponent : IHelpTextFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultHelpTextFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public HelpText CreateHelpText (TextManager textManager) {
			return _originalGameFactory.CreateHelpText (textManager);
		}
	}
}
