using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultTradeNetworkSolverFactoryComponent : ITradeNetworkSolverFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultTradeNetworkSolverFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TradeNetworkSolver CreateTradeNetworkSolver (Game game) {
			return _originalGameFactory.CreateTradeNetworkSolver (game);
		}
	}
}
