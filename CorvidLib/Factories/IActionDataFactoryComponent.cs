using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface IActionDataFactoryComponent : ICorvidFactoryComponent {
		ActionData CreateActionData (ActionType actionType, PlayerType playerType);
	}
}
