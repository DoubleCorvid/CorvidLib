using TenCrowns.GameCore;

namespace CorvidLib.Components.Defaults {
	public class DefaultCharacterFactoryComponent : ICharacterFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => ComponentManager.DefaultComponentId;

		public DefaultCharacterFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Character CreateCharacter () {
			return _originalGameFactory.CreateCharacter ();
		}
	}
}
