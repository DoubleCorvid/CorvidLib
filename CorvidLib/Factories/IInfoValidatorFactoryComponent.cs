using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IInfoValidatorFactoryComponent : ICorvidFactoryComponent {
		IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger);
	}
}
