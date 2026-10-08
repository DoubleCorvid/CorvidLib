using TenCrowns.GameCore;

namespace CorvidLib.Factories {
	public interface ICharacterFactoryComponent : ICorvidFactoryComponent {
		Character CreateCharacter ();
	}
}
