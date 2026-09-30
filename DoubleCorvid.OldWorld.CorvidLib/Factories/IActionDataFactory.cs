using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface IActionDataFactory {
	ActionData CreateActionData (ActionType actionType, PlayerType playerType);
}
