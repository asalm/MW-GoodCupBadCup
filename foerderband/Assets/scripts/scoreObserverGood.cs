using UnityEngine;
using System.Collections;

/*
 * Process Objects that pass the GoodCollider and increases score (if object was a good cup) or decreases life (if obeject was a bad cup)
 */

public class scoreObserverGood : MonoBehaviour {
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals ("Good"))
			GUI.score++;
		else if (other.tag.Equals ("Bad")) {
			GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
			GameObject.Find ("Main Camera").GetComponent<GUI> ().lifeCounter = GUI.timeAnz + 2;
		}
	}
}
