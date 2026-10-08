using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib.Factories.Defaults {
	public class DefaultColorManagerFactoryComponent : IColorManagerFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultColorManagerFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ColorManager CreateColorManager (Infos infos, TextManager textManager) {
			return _originalGameFactory.CreateColorManager (infos, textManager);
		}
	}
}
