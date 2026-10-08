using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Components.Defaults {
	public class DefaultColorManagerFactoryComponent : IColorManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultColorManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ColorManager CreateColorManager (Infos infos, TextManager textManager) {
			return _originalGameFactory.CreateColorManager (infos, textManager);
		}
	}
}
