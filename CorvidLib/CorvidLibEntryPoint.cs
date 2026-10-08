using TenCrowns.AppCore;
using TenCrowns.GameCore;

namespace CorvidLib {
    public class CorvidLibEntryPoint : ModEntryPointAdapter {
        public override void Initialize (ModSettings modSettings) {
            modSettings.Factory = new CorvidGameFactory (modSettings.Factory);

            base.Initialize (modSettings);
        }
    }
}


