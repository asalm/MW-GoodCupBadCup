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

	private float screenWidth = Screen.width;
	private float screenHeight = Screen.height;

	void start(){
	}
	
	void Update(){

	}


	void OnGUI() {
		score = GUI.score * GUI.wave;
		pauseButton.fixedWidth = screenWidth / 6;
		pauseButton.fixedHeight = screenHeight / 6;

		Vector2 contentOffset = pauseButton.contentOffset;
		contentOffset.y = pauseButton.fixedHeight/3.3333f;
		pauseButton.contentOffset = contentOffset;


		GUILayout.BeginArea (new Rect (Screen.width-Screen.width/2 - pauseButton.fixedWidth/2, Screen.height - Screen.height / 2 - pauseButton.fixedHeight / 2, 300, 500));
		//Die erreichten Werte werden untereinander angezeigt
		GUILayout.Label ("Erreichte Welle: " + GUI.wave, fontStyle);
		GUILayout.Label ("Erreichter Punktestand: " + GUI.score, fontStyle);
		GUILayout.Label("Final Score: " + score, fontStyle);

        if (GUILayout.Button("Back to the Menu", pauseButton))
		{
			//Wieder zum Menü
            Application.LoadLevel(0);

		}
		GUILayout.EndArea ();
	}
}
