using UnityEngine;
using System.Collections;

/*
 * Process Objects that pass the GoodCollider and increases score (if object was a good cup) or decreases life (if obeject was a bad cup)
 */

public class scoreObserverGood : MonoBehaviour {
<<<<<<< HEAD
    public AudioClip life_down;
    public AudioSource sounds;

    void OnTriggerEnter(Collider other) {
		if (other.tag.Equals ("Good"))
			GUI.score++;
		else if (other.tag.Equals ("Bad")) {
            sounds = GetComponent<AudioSource>();
            sounds.clip = life_down;
            sounds.Play();
            GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
=======
	
	void OnTriggerEnter(Collider other) {
		if (other.tag.Equals ("Good"))
			GUI.score++;
		else if (other.tag.Equals ("Bad")) {
			GameObject.Find ("Main Camera").GetComponent<GUI> ().leben--;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
			GameObject.Find ("Main Camera").GetComponent<GUI> ().lifeCounter = GUI.timeAnz + 2;
		}
	}
}
