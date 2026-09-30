using TenCrowns.ClientCore;
using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IInfoValidatorFactory {
	IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger);
}
