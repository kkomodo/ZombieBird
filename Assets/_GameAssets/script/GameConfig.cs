

public class GameConfig {
	public static bool jugando = true;

	public static bool IsPlaying() {
		return jugando;
	}

	public static void ArrancaJuego() {

		jugando  = true;
	}

	public static void PararJuego() {

		jugando  = false;
	}
	
	
	}

