using TenCrowns.GameCore;

namespace DoubleCorvid.OldWorld.CorvidLib.Factories;

public interface ITradeNetworkSolverFactory {
	TradeNetworkSolver CreateTradeNetworkSolver (Game game);
}
