using TenCrowns.GameCore;

namespace CorvidLib.Components {
	public interface ICharacterFactoryComponent : ICorvidFactoryComponent {
		Character CreateCharacter ();
	}
}
