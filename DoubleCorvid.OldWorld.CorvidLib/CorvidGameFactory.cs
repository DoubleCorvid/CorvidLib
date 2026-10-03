using DoubleCorvid.OldWorld.CorvidLib.Factories;
using TenCrowns.ClientCore;
using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace DoubleCorvid.OldWorld.CorvidLib {

}

	public class CorvidGameFactory : GameFactory {
		public IInfosFactory InfosFactory { get; set; } = null;

		public IInfoGlobalsFactory InfoGlobalsFactory { get; set; } = null;

		public IInfoHelpersFactory InfoHelpersFactory { get; set; } = null;

		public IInfoValidatorFactory InfoValidatorFactory { get; set; } = null;

		public ITextManagerFactory TextManagerFactory { get; set; } = null;

		public IHelpTextFactory HelpTextFactory { get; set; } = null;

		public IColorManagerFactory ColorManagerFactory { get; set; } = null;

		public IMatchFactory MatchFactory { get; set; } = null;

		public IPlayerFactory PlayerFactory { get; set; } = null;

		public IPlayerAIFactory PlayerAIFactory { get; set; } = null;

		public IUnitRoleManagerFactory UnitRoleManagerFactory { get; set; } = null;

		public ITribeFactory TribeFactory { get; set; } = null;

		public IUnitFactory UnitFactory { get; set; } = null;

		public IUnitAIFactory UnitAIFactory { get; set; } = null;

		public ICityFactory CityFactory { get; set; } = null;

		public ITileFactory TileFactory { get; set; } = null;

		public ITileDataFactory TileDataFactory { get; set; } = null;

		public ICharacterFactory CharacterFactory { get; set; } = null;

		public ITechTreeFactory TechTreeFactory { get; set; } = null;

		public IClientUIFactory ClientUIFactory { get; set; } = null;

		public IClientInputFactory ClientInputFactory { get; set; } = null;

		public IClientRendererFactory ClientRendererFactory { get; set; } = null;

		public IClientSelectionFactory ClientSelectionFactory { get; set; } = null;

		public IClientManagerFactory ClientManagerFactory { get; set; } = null;

		public IClientConsoleCommandsFactory ClientConsoleCommandsFactory { get; set; } = null;

		public IMapBuilderFactory MapBuilderFactory { get; set; } = null;

		public IActionDataFactory ActionDataFactory { get; set; } = null;

		public IGameHelpersFactory GameHelpersFactory { get; set; } = null;

		public IPathFinderFactory PathFinderFactory { get; set; } = null;

		public IRoadPathfinderFactory RoadPathfinderFactory { get; set; } = null;

		public ITradeNetworkSolverFactory TradeNetworkSolverFactory { get; set; } = null;

		public IUtilsFactory UtilsFactory { get; set; } = null;

		public override Infos CreateInfos (ModSettings modSettings) {
			return InfosFactory != null ? InfosFactory.CreateInfos (modSettings) : base.CreateInfos (modSettings);
		}

		public override InfoGlobals CreateInfoGlobals () {
			return InfoGlobalsFactory != null ? InfoGlobalsFactory.CreateInfoGlobals () : base.CreateInfoGlobals ();
		}

		public override InfoHelpers CreateInfoHelpers (Infos infos) {
			return InfoHelpersFactory != null ? InfoHelpersFactory.CreateInfoHelpers (infos) : base.CreateInfoHelpers (infos);
		}

		public override IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger) {
			return InfoValidatorFactory != null ? InfoValidatorFactory.CreateInfoValidator (fullValidation, logger) : base.CreateInfoValidator (fullValidation, logger);
		}

		public override TextManager CreateTextManager (Infos infos, LanguageType languageType) {
			return TextManagerFactory != null ? TextManagerFactory.CreateTextManager (infos, languageType) : base.CreateTextManager (infos, languageType);
		}

		public override HelpText CreateHelpText (TextManager textManager) {
			return HelpTextFactory != null ? HelpTextFactory.CreateHelpText (textManager) : base.CreateHelpText (textManager);
		}

		public override ColorManager CreateColorManager (Infos infos, TextManager textManager) {
			return ColorManagerFactory != null ? ColorManagerFactory.CreateColorManager (infos, textManager) : base.CreateColorManager (infos, textManager);
		}

		public override Game CreateGame (ModSettings modSettings, IApplication application, bool showGame) {
			return MatchFactory != null ? MatchFactory.CreateMatch (modSettings, application, showGame) : base.CreateGame (modSettings, application, showGame);
		}

		public override Player CreatePlayer () {
			return PlayerFactory != null ? PlayerFactory.CreatePlayer () : base.CreatePlayer ();
		}

		public override Player.PlayerAI CreatePlayerAI () {
			return PlayerAIFactory != null ? PlayerAIFactory.CreatePlayerAI () : base.CreatePlayerAI ();
		}

		public override Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game) {
			return UnitRoleManagerFactory != null ? UnitRoleManagerFactory.CreateUnitRoleManager (game) : base.CreateUnitRoleManager (game);
		}

		public override Tribe CreateTribe () {
			return TribeFactory != null ? TribeFactory.CreateTribe () : base.CreateTribe ();
		}

		public override Unit CreateUnit () {
			return UnitFactory != null ? UnitFactory.CreateUnit () : base.CreateUnit ();
		}

		public override Unit.UnitAI CreateUnitAI () {
			return UnitAIFactory != null ? UnitAIFactory.CreateUnitAI () : base.CreateUnitAI ();
		}

		public override City CreateCity () {
			return CityFactory != null ? CityFactory.CreateCity () : base.CreateCity ();
		}

		public override Tile CreateTile () {
			return TileFactory != null ? TileFactory.CreateTile () : base.CreateTile ();
		}

		public override TileData CreateTileData (int id) {
			return TileDataFactory != null ? TileDataFactory.CreateTileData () : base.CreateTileData (id);
		}

		public override Character CreateCharacter () {
			return CharacterFactory != null ? CharacterFactory.CreateCharacter () : base.CreateCharacter ();
		}

		public override TechTree CreateTechTree () {
			return TechTreeFactory != null ? TechTreeFactory.CreateTechTree () : base.CreateTechTree ();
		}

		public override ClientUI CreateClientUI (IApplication app) {
			return ClientUIFactory != null ? ClientUIFactory.CreateClientUI (app) : base.CreateClientUI (app);
		}

		public override ClientInput CreateClientInput (IApplication app) {
			return ClientInputFactory != null ? ClientInputFactory.CreateClientInput (app) : base.CreateClientInput (app);
		}

		public override ClientRenderer CreateClientRenderer (IApplication app) {
			return ClientRendererFactory != null ? ClientRendererFactory.CreateClientRenderer (app) : base.CreateClientRenderer (app);
		}

		public override ClientSelection CreateClientSelection (IApplication app) {
			return ClientSelectionFactory != null ? ClientSelectionFactory.CreateClientSelection (app) : base.CreateClientSelection (app);
		}

		public override ClientManager CreateClientManager (GameInterfaces gameInterfaces) {
			return ClientManagerFactory != null ? ClientManagerFactory.CreateClientManager (gameInterfaces) : base.CreateClientManager (gameInterfaces);
		}

		public override ClientConsoleCommands CreateClientConsoleCommands (IApplication app) {
			return ClientConsoleCommandsFactory != null ? ClientConsoleCommandsFactory.CreateClientConsoleCommands (app) : base.CreateClientConsoleCommands (app);
		}

		public override MapBuilder CreateMapBuilder () {
			return MapBuilderFactory != null ? MapBuilderFactory.CreateMapBuilder () : base.CreateMapBuilder ();
		}

		public override ActionData CreateActionData (ActionType actionType, PlayerType playerType) {
			return ActionDataFactory != null ? ActionDataFactory.CreateActionData (actionType, playerType) : base.CreateActionData (actionType, playerType);
		}

		public override GameHelpers CreateGameHelperInstance () {
			return GameHelpersFactory != null ? GameHelpersFactory.CreateGameHelpers () : base.CreateGameHelperInstance ();
		}

		public override PathFinder CreatePathfinder () {
			return PathFinderFactory != null ? PathFinderFactory.CreatePathFinder () : base.CreatePathfinder ();
		}

		public override RoadPathfinder CreateRoadPathfinder (Game game) {
			return RoadPathfinderFactory != null ? RoadPathfinderFactory.CreateRoadPathfinder (game) : base.CreateRoadPathfinder (game);
		}

		public override TradeNetworkSolver CreateTradeNetworkSolver (Game game) {
			return TradeNetworkSolverFactory != null ? TradeNetworkSolverFactory.CreateTradeNetworkSolver (game) : base.CreateTradeNetworkSolver (game);
		}

		public override Utils CreateUtils () {
			return UtilsFactory != null ? UtilsFactory.CreateUtils () : base.CreateUtils ();
		}
	}
