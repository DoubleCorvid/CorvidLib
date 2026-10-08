using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface IActionDataFactoryComponent : ICorvidFactoryComponent {
		ActionData CreateActionData (ActionType actionType, PlayerType playerType);
	}
}
