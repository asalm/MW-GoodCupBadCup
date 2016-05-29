using UnityEngine;
using System.Collections;

/*
 * Process Objects that pass the BadCollider
 */

public class scoreObserverBad : MonoBehaviour {

	public Camera mainCam;

	void OnTriggerEnter(Collider other)
	{
		if (other.tag.Equals ("Bad")) {
			GUI.score++;				//Increase score of player if badCup was terminated
		} else if (other.tag.Equals ("PowerUp")) {
			switch (other.gameObject.name) {
			case "OneUp(Clone)":
				if (GameObject.Find ("Main Camera").GetComponent<GUI> ().leben < 5)			//if powerUp was OneUp the live will increase
					GameObject.Find ("Main Camera").GetComponent<GUI> ().leben++;
				break;
			case "SlowDown(Clone)":
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownStart = GUI.timeAnz;	//if powerUp was SlowDown the cups will move slower
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownActive = true;
				break;
			case "Invert(Clone)":
				mainCam.GetComponent<InvertScreen> ().i = 0;
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownStart = GUI.timeAnz;		//if powerup was Invert the Camera will rotate with animation
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownDuration = 1.4f;
				GameObject.Find ("Treadmill").GetComponent<TreadmillRegulator> ().slowDownActive = true;

				break;
			default:
				break;
			}
			
		} else {
			GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
			GameObject.Find ("Main Camera").GetComponent<GUI> ().lifeCounter = GUI.timeAnz + 2;
		}
		}
}
