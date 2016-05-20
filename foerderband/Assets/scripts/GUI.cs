using UnityEngine;
using System.Collections;

public class GUI : MonoBehaviour {
	
	public bool isPaused;
	public int leben = 3;
	public static int score;
	public float time = 0;
	public static int timeAnz = 0;
	public static int wave;
	
	private float screenWidth = Screen.width;
	private float screenHeight = Screen.height;
	
	public Texture2D lives;
	
	public GUIStyle fontStyle = new GUIStyle();
	public GUIStyle pauseButton = new GUIStyle();
	
	void start() {
		isPaused = false;
	}
	
	void Update() {
		time = time + Time.deltaTime;
		if (time >= 1.0f) {
			timeAnz += 1;
			time = 0;
		}
		
		Debug.Log ("Width:  " + screenWidth);
	}
	
	void OnGUI() {
		GUILayout.BeginArea(new Rect(Screen.width - 115, 5, 100, 80));
		if (!isPaused)
		{
			if (GUILayout.Button("Pause", pauseButton))
<<<<<<< HEAD
            {
                Time.timeScale = 0;
                isPaused = true;
            }
        } else
			GUILayout.Label ("Pausiert", fontStyle);
		GUILayout.EndArea ();
		GUILayout.BeginArea(new Rect(Screen.width/2-50, Screen.height/5.5f, 200, 300));
        if (isPaused)
        {

=======
			{
				Time.timeScale = 0;
				isPaused = true;
			}
		} else
			GUILayout.Label ("Pausiert", fontStyle);
		GUILayout.EndArea ();
		GUILayout.BeginArea(new Rect(Screen.width/2-50, Screen.height/5.5f, 200, 300));
		if (isPaused)
		{
			
>>>>>>> origin/master
			if (GUILayout.Button("Weiter", pauseButton))
			{
				Time.timeScale = 1;
				isPaused = false;
			}
			GUILayout.Label("");
			if(GUILayout.Button ("Menü", pauseButton))
			{
				Application.LoadLevel(0);
				Time.timeScale = 1;
			}
<<<<<<< HEAD



        }
		
		GUILayout.EndArea();
		GUILayout.BeginArea (new Rect (Screen.width - 115, 60, 100, 80));
        if (leben <= 0)
        {
            Application.LoadLevel(2);
        }
		fontStyle.fontSize = 20;
        GUILayout.Label("Welle: " + wave, fontStyle);
        GUILayout.EndArea();

        GUILayout.BeginArea(new Rect(5, 60, 100, 80));

        GUILayout.Label("Score: " + score, fontStyle);
        GUILayout.EndArea();

        drawLives();
    }

    private void drawLives()
    {
        GUILayout.BeginHorizontal();
        for (int i = 0; i < leben; i++)
        {
            GUILayout.Label(lives);
            
        }
        GUILayout.EndHorizontal();
        
    }
=======
			
			
			
		}
		
		GUILayout.EndArea();
		GUILayout.BeginArea (new Rect (Screen.width - 115, 60, 100, 80));
		if (leben <= 0)
		{
			Application.LoadLevel(2);
		}
		//fontStyle.fontSize = 20;
		GUILayout.Label("Welle: " + wave, fontStyle);
		GUILayout.EndArea();
		
		GUILayout.BeginArea(new Rect(5, 60, 100, 80));
		
		GUILayout.Label("Score: " + score, fontStyle);
		GUILayout.EndArea();
		
		drawLives();
	}
	
	private void drawLives()
	{
		GUILayout.BeginHorizontal();
		for (int i = 0; i < leben; i++)
		{
			GUILayout.Label(lives);
			
		}
		GUILayout.EndHorizontal();
		
	}
>>>>>>> origin/master
}
