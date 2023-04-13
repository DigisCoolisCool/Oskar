using UnityEngine;
using System.Collections;

public class PlayerScript : MonoBehaviour {


	public int coins;
	

	// Start is called on the frame when a script is enabled just before any of the Update methods is called the first time.
	protected void Start() {
		coins = 0;
		Abilities.spinAttackEnabled = false;
		Abilities.doubleJumpEnabled = false;
	}

	// OnTriggerEnter is called when the Collider "collided" enters the trigger.
	protected void OnTriggerEnter(Collider collided) {

		// Check for collision with coins
		if (collided.gameObject.tag == "Coin") {

			Destroy(collided.gameObject);
			coins++;
			HUD.Message("YES!");
			HUD.UpdateCoinCount(coins);

		}


		if (collided.gameObject.name == "tp2") {

			Destroy(collided.gameObject);
			HUD.Message("güüd now tp");
			Abilities.doubleJumpEnabled = true;


		}

		if (collided.gameObject.name == "tp3")  {
			
            Destroy(collided.gameObject);
			HUD.Message("attack");
			Abilities.spinAttackEnabled = true;
		
		
		
		
		}

    }

}

