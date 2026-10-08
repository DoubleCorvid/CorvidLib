using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultUnitAIFactoryComponent : IUnitAIFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultUnitAIFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Unit.UnitAI CreateUnitAI () {
			return _originalGameFactory.CreateUnitAI ();
		}
	}
}
