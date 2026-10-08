using System;
using System.Collections.Concurrent;
using CorvidLib.Factories;
using CorvidLib.Factories.Defaults;
using TenCrowns.GameCore;

namespace CorvidLib {
    public class CorvidFactoryComponentManager {
		public const string DefaultComponentId = "OldWorld";

		private readonly ConcurrentDictionary<Type, ICorvidFactoryComponent> _components = new ConcurrentDictionary<Type, ICorvidFactoryComponent> ();

		public CorvidFactoryComponentManager (GameFactory originalGameFactory) {
			AddComponent (typeof (IInfosFactoryComponent), new DefaultInfosFactoryComponent (originalGameFactory));
			AddComponent (typeof (IInfoGlobalsFactoryComponent), new DefaultInfoGlobalsFactoryComponent (originalGameFactory));
			AddComponent (typeof (IInfoHelpersFactoryComponent), new DefaultInfoHelpersFactoryComponent (originalGameFactory));
			AddComponent (typeof (IInfoValidatorFactoryComponent), new DefaultInfoValidatorFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITextManagerFactoryComponent), new DefaultTextManagerFactoryComponent (originalGameFactory));
			AddComponent (typeof (IHelpTextFactoryComponent), new DefaultHelpTextFactoryComponent (originalGameFactory));
			AddComponent (typeof (IColorManagerFactoryComponent), new DefaultColorManagerFactoryComponent (originalGameFactory));
			AddComponent (typeof (IGameFactoryComponent), new DefaultGameFactoryComponent (originalGameFactory));
			AddComponent (typeof (IPlayerFactoryComponent), new DefaultPlayerFactoryComponent (originalGameFactory));
			AddComponent (typeof (IPlayerAIFactoryComponent), new DefaultPlayerAIFactoryComponent (originalGameFactory));
			AddComponent (typeof (IUnitRoleManagerFactoryComponent), new DefaultUnitRoleManagerFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITribeFactoryComponent), new DefaultTribeFactoryComponent (originalGameFactory));
			AddComponent (typeof (IUnitFactoryComponent), new DefaultUnitFactoryComponent (originalGameFactory));
			AddComponent (typeof (IUnitAIFactoryComponent), new DefaultUnitAIFactoryComponent (originalGameFactory));
			AddComponent (typeof (ICityFactoryComponent), new DefaultCityFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITileFactoryComponent), new DefaultTileFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITileDataFactoryComponent), new DefaultTileDataFactoryComponent (originalGameFactory));
			AddComponent (typeof (ICharacterFactoryComponent), new DefaultCharacterFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITechTreeFactoryComponent), new DefaultTechTreeFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientUIFactoryComponent), new DefaultClientUIFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientInputFactoryComponent), new DefaultClientInputFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientRendererFactoryComponent), new DefaultClientRendererFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientSelectionFactoryComponent), new DefaultClientSelectionFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientManagerFactoryComponent), new DefaultClientManagerFactoryComponent (originalGameFactory));
			AddComponent (typeof (IClientConsoleCommandsFactoryComponent), new DefaultClientConsoleCommandsFactoryComponent (originalGameFactory));
			AddComponent (typeof (IMapBuilderFactoryComponent), new DefaultMapBuilderFactoryComponent (originalGameFactory));
			AddComponent (typeof (IActionDataFactoryComponent), new DefaultActionDataFactoryComponent (originalGameFactory));
			AddComponent (typeof (IGameHelpersFactoryComponent), new DefaultGameHelpersFactoryComponent (originalGameFactory));
			AddComponent (typeof (IPathFinderFactoryComponent), new DefaultPathFinderFactoryComponent (originalGameFactory));
			AddComponent (typeof (IRoadPathfinderFactoryComponent), new DefaultRoadPathfinderFactoryComponent (originalGameFactory));
			AddComponent (typeof (ITradeNetworkSolverFactoryComponent), new DefaultTradeNetworkSolverFactoryComponent (originalGameFactory));
			AddComponent (typeof (IUtilsFactoryComponent), new DefaultUtilsFactoryComponent (originalGameFactory));
		}

		public T GetComponent<T> () where T : ICorvidFactoryComponent {
			if (_components.TryGetValue (typeof (T), out var value)) {
				return (T) value;
			}

			return default;
		}

		public bool AddComponent (Type type, ICorvidFactoryComponent component) {
			return _components.TryAdd (type, component);
		}

		public bool UpdateComponent (Type type, ICorvidFactoryComponent component) {
			if (_components.TryGetValue (type, out var cached) && cached.ModId == DefaultComponentId) {
				return _components.TryUpdate (type, component, cached);
			}

			return false;
		}
	}
}
