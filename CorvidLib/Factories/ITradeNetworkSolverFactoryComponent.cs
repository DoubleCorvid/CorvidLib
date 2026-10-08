using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ITradeNetworkSolverFactoryComponent : ICorvidFactoryComponent {
		TradeNetworkSolver CreateTradeNetworkSolver (Game game);
	}
}
