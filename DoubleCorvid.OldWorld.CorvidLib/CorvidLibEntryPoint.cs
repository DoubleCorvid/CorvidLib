using TenCrowns.AppCore;
using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib {
    public class CorvidLibEntryPoint : ModEntryPointAdapter {
        public override void Initialize (ModSettings modSettings) {
            modSettings.Factory = new CorvidGameFactory ();

            base.Initialize (modSettings);
        }
    }
}


