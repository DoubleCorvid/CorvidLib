using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultTradeNetworkSolverFactoryComponent : ITradeNetworkSolverFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultTradeNetworkSolverFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public TradeNetworkSolver CreateTradeNetworkSolver (Game game) {
			return _originalGameFactory.CreateTradeNetworkSolver (game);
		}
	}
}
