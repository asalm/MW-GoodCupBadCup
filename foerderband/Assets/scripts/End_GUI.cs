using UnityEngine;
using System.Collections;

/*
 * This script will show the total score of the player and the way he/she reached
 * and offers the function to get back to game-menu
 *
 */

public class End_GUI : MonoBehaviour {
	private int score;

	public GUIStyle fontStyle = new GUIStyle();
	public GUIStyle pauseButton = new GUIStyle();

	void start(){
	}
	
	void Update(){

	}


	void OnGUI() {
		score = GUI.score * GUI.wave;
        int buttonWidth = 200, buttonHeight = 100;
		GUILayout.BeginArea (new Rect (Screen.width-Screen.width/2 - buttonWidth/2, Screen.height - Screen.height / 2 - buttonHeight / 2, 300, 500));
		GUILayout.Label ("Erreichte Welle: " + GUI.wave, fontStyle);
		GUILayout.Label ("Erreichter Punktestand: " + GUI.score, fontStyle);
		GUILayout.Label("Final Score: " + score, fontStyle);

        if (GUILayout.Button("Back to the Menu", pauseButton))
		{
            Application.LoadLevel(0);

		}
		GUILayout.EndArea ();
	}
}
