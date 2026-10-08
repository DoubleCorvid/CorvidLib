using TenCrowns.GameCore;

namespace CorvidLib.Factories.Defaults {
	public class DefaultCharacterFactoryComponent : ICharacterFactoryComponent {
		private readonly GameFactory _originalGameFactory;

		public string ModId => "TenCrowns";

		public DefaultCharacterFactoryComponent (GameFactory originalGameFactory) {
			_originalGameFactory = originalGameFactory;
		}

		public Character CreateCharacter () {
			return _originalGameFactory.CreateCharacter ();
		}
	}
}
