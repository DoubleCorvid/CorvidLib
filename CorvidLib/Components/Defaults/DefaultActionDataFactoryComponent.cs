using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultActionDataFactoryComponent : IActionDataFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultActionDataFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public ActionData CreateActionData (ActionType actionType, PlayerType playerType) {
			return _originalGameFactory.CreateActionData (actionType, playerType);
		}
	}
}
