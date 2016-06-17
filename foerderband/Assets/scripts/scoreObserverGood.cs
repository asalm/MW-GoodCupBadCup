﻿using UnityEngine;
using System.Collections;

/*
 * Process Objects that pass the GoodCollider and increases score (if object was a good cup) or decreases life (if obeject was a bad cup)
 */

public class scoreObserverGood : MonoBehaviour {
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
			GameObject.Find ("Main Camera").GetComponent<GUI> ().lifeCounter = GUI.timeAnz + 2;
		}
	}
}
