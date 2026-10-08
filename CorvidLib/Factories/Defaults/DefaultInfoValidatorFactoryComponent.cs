using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultInfoValidatorFactoryComponent : IInfoValidatorFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultInfoValidatorFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger) {
			return _originalGameFactory.CreateInfoValidator (fullValidation, logger);
		}
	}
}
