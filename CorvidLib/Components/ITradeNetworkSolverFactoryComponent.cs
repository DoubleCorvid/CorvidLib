using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ITradeNetworkSolverFactoryComponent : ICorvidFactoryComponent {
		TradeNetworkSolver CreateTradeNetworkSolver (Game game);
	}
}
