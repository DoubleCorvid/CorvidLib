using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultUnitAIFactoryComponent : IUnitAIFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultUnitAIFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Unit.UnitAI CreateUnitAI () {
			return _originalGameFactory.CreateUnitAI ();
		}
	}
}
