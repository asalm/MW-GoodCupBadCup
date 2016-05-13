using UnityEngine;
using System.Collections;

public class Start_GUI : MonoBehaviour {
	
	public bool isPaused;
	public int leben = 3;
	public int score = 0;
	public float time = 0;
	public int timeAnz = 0;
	
	public GUIStyle fontStyle = new GUIStyle();
	public GUIStyle pauseButton = new GUIStyle();
	
	void start(){	
	}
	
	void Update(){
	}
	
	void OnGUI() {
        int buttonWidth = 200, buttonHeight = 100;
        GUILayout.BeginArea(new Rect(Screen.width - Screen.width / 2 - buttonWidth / 2, Screen.height - Screen.height / 2 - buttonHeight / 2, buttonWidth, 500));
        if (GUILayout.Button("Start", pauseButton))
		{
            Application.LoadLevel(1);
			GUI.timeAnz =0;
			GUI.score = 0;
			score = 0;
			GUI.wave = 0;
        }
		GUILayout.Label ("");
		if (GUILayout.Button("Back to the Menu", pauseButton))
		{
            Debug.Log("NADA!");
		}
		GUILayout.EndArea ();
	}
}
