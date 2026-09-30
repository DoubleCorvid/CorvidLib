using DoubleCorvid.OldWorld.CorvidLib.Factories;

using TenCrowns.ClientCore;
using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace DoubleCorvid.OldWorld.CorvidLib;

public class CorvidGameFactory : GameFactory {
	public IInfosFactory? InfosFactory { get; set; }

	public IInfoGlobalsFactory? InfoGlobalsFactory { get; set; }

	public IInfoHelpersFactory? InfoHelpersFactory { get; set; }

	public IInfoValidatorFactory? InfoValidatorFactory { get; set; }

	public ITextManagerFactory? TextManagerFactory { get; set; }

	public IHelpTextFactory? HelpTextFactory { get; set; }

	public IColorManagerFactory? ColorManagerFactory { get; set; }

	public IMatchFactory? MatchFactory { get; set; }

	public IPlayerFactory? PlayerFactory { get; set; }

	public IPlayerAIFactory? PlayerAIFactory { get; set; }

	public IUnitRoleManagerFactory? UnitRoleManagerFactory { get; set; }

	public ITribeFactory? TribeFactory { get; set; }

	public IUnitFactory? UnitFactory { get; set; }

	public IUnitAIFactory? UnitAIFactory { get; set; }

	public ICityFactory? CityFactory { get; set; }

	public ITileFactory? TileFactory { get; set; }

	public ITileDataFactory? TileDataFactory { get; set; }

	public ICharacterFactory? CharacterFactory { get; set; }

	public ITechTreeFactory? TechTreeFactory { get; set; }

	public IClientUIFactory? ClientUIFactory { get; set; }

	public IClientInputFactory? ClientInputFactory { get; set; }

	public IClientRendererFactory? ClientRendererFactory { get; set; }

	public IClientSelectionFactory? ClientSelectionFactory { get; set; }

	public IClientManagerFactory? ClientManagerFactory { get; set; }

	public IClientConsoleCommandsFactory? ClientConsoleCommandsFactory { get; set; }

	public IMapBuilderFactory? MapBuilderFactory { get; set; }

	public IActionDataFactory? ActionDataFactory { get; set; }

	public IGameHelpersFactory? GameHelpersFactory { get; set; }

	public IPathFinderFactory? PathFinderFactory { get; set; }

	public IRoadPathfinderFactory? RoadPathfinderFactory { get; set; }

	public ITradeNetworkSolverFactory? TradeNetworkSolverFactory { get; set; }

	public IUtilsFactory? UtilsFactory { get; set; }


	public override Infos CreateInfos (ModSettings modSettings) {
		return InfosFactory is not null ? InfosFactory.CreateInfos (modSettings) : base.CreateInfos (modSettings);
	}

	public override InfoGlobals CreateInfoGlobals () {
		return InfoGlobalsFactory is not null ? InfoGlobalsFactory.CreateInfoGlobals () : base.CreateInfoGlobals ();
	}

	public override InfoHelpers CreateInfoHelpers (Infos infos) {
		return InfoHelpersFactory is not null ? InfoHelpersFactory.CreateInfoHelpers (infos) : base.CreateInfoHelpers (infos);
	}

	public override IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger) {
		return InfoValidatorFactory is not null ? InfoValidatorFactory.CreateInfoValidator (fullValidation, logger) : base.CreateInfoValidator (fullValidation, logger);
	}

	public override TextManager CreateTextManager (Infos infos, LanguageType languageType) {
		return TextManagerFactory is not null ? TextManagerFactory.CreateTextManager (infos, languageType) : base.CreateTextManager (infos, languageType);
	}

	public override HelpText CreateHelpText (TextManager textManager) {
		return HelpTextFactory is not null ? HelpTextFactory.CreateHelpText (textManager) : base.CreateHelpText (textManager);
	}

	public override ColorManager CreateColorManager (Infos infos, TextManager textManager) {
		return ColorManagerFactory is not null ? ColorManagerFactory.CreateColorManager (infos, textManager) : base.CreateColorManager (infos, textManager);
	}

	public override Game CreateGame (ModSettings modSettings, IApplication application, bool showGame) {
		return MatchFactory is not null ? MatchFactory.CreateMatch (modSettings, application, showGame) : base.CreateGame (modSettings, application, showGame);
	}

	public override Player CreatePlayer () {
		return PlayerFactory is not null ? PlayerFactory.CreatePlayer () : base.CreatePlayer ();
	}

	public override Player.PlayerAI CreatePlayerAI () {
		return PlayerAIFactory is not null ? PlayerAIFactory.CreatePlayerAI () : base.CreatePlayerAI ();
	}

	public override Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game) {
		return UnitRoleManagerFactory is not null ? UnitRoleManagerFactory.CreateUnitRoleManager (game) : base.CreateUnitRoleManager (game);
	}

	public override Tribe CreateTribe () {
		return TribeFactory is not null ? TribeFactory.CreateTribe () : base.CreateTribe ();
	}

	public override Unit CreateUnit () {
		return UnitFactory is not null ? UnitFactory.CreateUnit () : base.CreateUnit ();
	}

	public override Unit.UnitAI CreateUnitAI () {
		return UnitAIFactory is not null ? UnitAIFactory.CreateUnitAI () : base.CreateUnitAI ();
	}

	public override City CreateCity () {
		return CityFactory is not null ? CityFactory.CreateCity () : base.CreateCity ();
	}

	public override Tile CreateTile () {
		return TileFactory is not null ? TileFactory.CreateTile () : base.CreateTile ();
	}

	public override TileData CreateTileData (int id) {
		return TileDataFactory is not null ? TileDataFactory.CreateTileData () : base.CreateTileData (id);
	}

	public override Character CreateCharacter () {
		return CharacterFactory is not null ? CharacterFactory.CreateCharacter () : base.CreateCharacter ();
	}

	public override TechTree CreateTechTree () {
		return TechTreeFactory is not null ? TechTreeFactory.CreateTechTree () : base.CreateTechTree ();
	}

	public override ClientUI CreateClientUI (IApplication app) {
		return ClientUIFactory is not null ? ClientUIFactory.CreateClientUI (app) : base.CreateClientUI (app);
	}

	public override ClientInput CreateClientInput (IApplication app) {
		return ClientInputFactory is not null ? ClientInputFactory.CreateClientInput (app) : base.CreateClientInput (app);
	}

	public override ClientRenderer CreateClientRenderer (IApplication app) {
		return ClientRendererFactory is not null ? ClientRendererFactory.CreateClientRenderer (app) : base.CreateClientRenderer (app);
	}

	public override ClientSelection CreateClientSelection (IApplication app) {
		return ClientSelectionFactory is not null ? ClientSelectionFactory.CreateClientSelection (app) : base.CreateClientSelection (app);
	}

	public override ClientManager CreateClientManager (GameInterfaces gameInterfaces) {
		return ClientManagerFactory is not null ? ClientManagerFactory.CreateClientManager (gameInterfaces) : base.CreateClientManager (gameInterfaces);
    }

    public override ClientConsoleCommands CreateClientConsoleCommands (IApplication app) {
		return ClientConsoleCommandsFactory is not null ? ClientConsoleCommandsFactory.CreateClientConsoleCommands (app) : base.CreateClientConsoleCommands (app);
	}

	public override MapBuilder CreateMapBuilder () {
		return MapBuilderFactory is not null ? MapBuilderFactory.CreateMapBuilder () : base.CreateMapBuilder ();
	}

	public override ActionData CreateActionData (ActionType actionType, PlayerType playerType) {
		return ActionDataFactory is not null ? ActionDataFactory.CreateActionData (actionType, playerType) : base.CreateActionData (actionType, playerType);
	}

	public override GameHelpers CreateGameHelperInstance () {
		return GameHelpersFactory is not null ? GameHelpersFactory.CreateGameHelpers () : base.CreateGameHelperInstance ();
	}

	public override PathFinder CreatePathfinder () {
		return PathFinderFactory is not null ? PathFinderFactory.CreatePathFinder () : base.CreatePathfinder ();
	}

	public override RoadPathfinder CreateRoadPathfinder (Game game) {
		return RoadPathfinderFactory is not null ? RoadPathfinderFactory.CreateRoadPathfinder (game) : base.CreateRoadPathfinder (game);
	}

	public override TradeNetworkSolver CreateTradeNetworkSolver (Game game) {
		return TradeNetworkSolverFactory is not null ? TradeNetworkSolverFactory.CreateTradeNetworkSolver (game) : base.CreateTradeNetworkSolver (game);
	}

	public override Utils CreateUtils () {
		return UtilsFactory is not null ? UtilsFactory.CreateUtils () : base.CreateUtils ();
	}
}
