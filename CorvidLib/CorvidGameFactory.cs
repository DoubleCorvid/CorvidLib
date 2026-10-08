using CorvidLib.Factories;

using TenCrowns.ClientCore;
using TenCrowns.GameCore;
using TenCrowns.GameCore.Text;

namespace CorvidLib {
	public class CorvidGameFactory : GameFactory {
		public readonly CorvidFactoryComponentManager ComponentManager;

		public CorvidGameFactory (GameFactory originalGameFactory) {
			ComponentManager = new CorvidFactoryComponentManager (originalGameFactory);
		}

		public override Infos CreateInfos (ModSettings modSettings) {
			return ComponentManager.GetComponent<IInfosFactoryComponent> ().CreateInfos (modSettings);
		}

		public override InfoGlobals CreateInfoGlobals () {
			return ComponentManager.GetComponent<IInfoGlobalsFactoryComponent> ().CreateInfoGlobals ();
		}

		public override InfoHelpers CreateInfoHelpers (Infos infos) {
			return ComponentManager.GetComponent<IInfoHelpersFactoryComponent> ().CreateInfoHelpers (infos);
		}

		public override IInfoValidator CreateInfoValidator (bool fullValidation, ILogger logger) {
			return ComponentManager.GetComponent<IInfoValidatorFactoryComponent> ().CreateInfoValidator (fullValidation, logger);
		}

		public override TextManager CreateTextManager (Infos infos, LanguageType languageType) {
			return ComponentManager.GetComponent<ITextManagerFactoryComponent> ().CreateTextManager (infos, languageType);
		}

		public override HelpText CreateHelpText (TextManager textManager) {
			return ComponentManager.GetComponent<IHelpTextFactoryComponent> ().CreateHelpText (textManager);
		}

		public override ColorManager CreateColorManager (Infos infos, TextManager textManager) {
			return ComponentManager.GetComponent<IColorManagerFactoryComponent> ().CreateColorManager (infos, textManager);
		}

		public override Game CreateGame (ModSettings modSettings, IApplication app, bool showGame) {
			return ComponentManager.GetComponent<IGameFactoryComponent> ().CreateGame (modSettings, app, showGame);
		}

		public override Player CreatePlayer () {
			return ComponentManager.GetComponent<IPlayerFactoryComponent> ().CreatePlayer ();
		}

		public override Player.PlayerAI CreatePlayerAI () {
			return ComponentManager.GetComponent<IPlayerAIFactoryComponent> ().CreatePlayerAI ();
		}

		public override Player.PlayerAI.UnitRoleManager CreateUnitRoleManager (Game game) {
			return ComponentManager.GetComponent<IUnitRoleManagerFactoryComponent> ().CreateUnitRoleManager (game);
		}

		public override Tribe CreateTribe () {
			return ComponentManager.GetComponent<ITribeFactoryComponent> ().CreateTribe ();
		}

		public override Unit CreateUnit () {
			return ComponentManager.GetComponent<IUnitFactoryComponent> ().CreateUnit ();
		}

		public override Unit.UnitAI CreateUnitAI () {
			return ComponentManager.GetComponent<IUnitAIFactoryComponent> ().CreateUnitAI ();
		}

		public override City CreateCity () {
			return ComponentManager.GetComponent<ICityFactoryComponent> ().CreateCity ();
		}

		public override Tile CreateTile () {
			return ComponentManager.GetComponent<ITileFactoryComponent> ().CreateTile ();
		}

		public override TileData CreateTileData (int id) {
			return ComponentManager.GetComponent<ITileDataFactoryComponent> ().CreateTileData (id);
		}

		public override Character CreateCharacter () {
			return ComponentManager.GetComponent<ICharacterFactoryComponent> ().CreateCharacter ();
		}

		public override TechTree CreateTechTree () {
			return ComponentManager.GetComponent<ITechTreeFactoryComponent> ().CreateTechTree ();
		}

		public override ClientUI CreateClientUI (IApplication app) {
			return ComponentManager.GetComponent<IClientUIFactoryComponent> ().CreateClientUI (app);
		}

		public override ClientInput CreateClientInput (IApplication app) {
			return ComponentManager.GetComponent<IClientInputFactoryComponent> ().CreateClientInput (app);
		}

		public override ClientRenderer CreateClientRenderer (IApplication app) {
			return ComponentManager.GetComponent<IClientRendererFactoryComponent> ().CreateClientRenderer (app);
		}

		public override ClientSelection CreateClientSelection (IApplication app) {
			return ComponentManager.GetComponent<IClientSelectionFactoryComponent> ().CreateClientSelection (app);
		}

		public override ClientManager CreateClientManager (GameInterfaces gameInterfaces) {
			return ComponentManager.GetComponent<IClientManagerFactoryComponent> ().CreateClientManager (gameInterfaces);
		}

		public override ClientConsoleCommands CreateClientConsoleCommands (IApplication app) {
			return ComponentManager.GetComponent<IClientConsoleCommandsFactoryComponent> ().CreateClientConsoleCommands (app);
		}

		public override MapBuilder CreateMapBuilder () {
			return ComponentManager.GetComponent<IMapBuilderFactoryComponent> ().CreateMapBuilder ();
		}

		public override ActionData CreateActionData (ActionType actionType, PlayerType playerType) {
			return ComponentManager.GetComponent<IActionDataFactoryComponent> ().CreateActionData (actionType, playerType);
		}

		public override GameHelpers CreateGameHelperInstance () {
			return ComponentManager.GetComponent<IGameHelpersFactoryComponent> ().CreateGameHelperInstance ();
		}

		public override PathFinder CreatePathfinder () {
			return ComponentManager.GetComponent<IPathFinderFactoryComponent> ().CreatePathfinder ();
		}

		public override RoadPathfinder CreateRoadPathfinder (Game game) {
			return ComponentManager.GetComponent<IRoadPathfinderFactoryComponent> ().CreateRoadPathfinder (game);
		}

		public override TradeNetworkSolver CreateTradeNetworkSolver (Game game) {
			return ComponentManager.GetComponent<ITradeNetworkSolverFactoryComponent> ().CreateTradeNetworkSolver (game);
		}

		public override Utils CreateUtils () {
			return ComponentManager.GetComponent<IUtilsFactoryComponent> ().CreateUtils ();
		}

	}
}
