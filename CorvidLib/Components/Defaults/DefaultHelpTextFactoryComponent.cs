using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components.Defaults {
	public class DefaultHelpTextFactoryComponent : IHelpTextFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultHelpTextFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public HelpText CreateHelpText (TextManager textManager) {
			return _originalGameFactory.CreateHelpText (textManager);
		}
	}
}
