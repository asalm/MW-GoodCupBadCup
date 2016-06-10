using UnityEngine;
using System.Collections;

/*
*Counts and deletes all "used" Gameobjects, calls new spawn 
*/

public class CupCounter : MonoBehaviour {
	private int destroyedCounter = 0;
	
	void OnTriggerEnter(Collider other)
	{
		destroyedCounter++;
		
		Destroy(other.gameObject);

        //Calls patternDrop methods to reset pattern and spawn new pattern
		if (GameObject.Find("Treadmill").GetComponent<patternDrop>().level == destroyedCounter)
		{

			destroyedCounter = 0;
			GameObject.Find ("Treadmill").GetComponent<patternDrop> ().roundInSeconds = 0;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().pattern.Clear();
			GameObject.Find("Treadmill").GetComponent<patternDrop>().alreadyExists = false;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().spawnPattern();
		}
	}

	public void setCounter(int c){
		destroyedCounter = c;
	}

    public void updateCounter()
    {
        destroyedCounter++;
    }

}
