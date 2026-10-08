using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IInfoValidatorFactoryComponent : ICorvidFactoryComponent {
		IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger);
	}
}
