using UnityEngine;
using System.Collections;

/*
*Counts and deletes all "used" Gameobjects, calls new spawn 
*/

public class CupCounter : MonoBehaviour {
<<<<<<< HEAD
	private int counter = 0;
	
	void OnTriggerEnter(Collider other)
	{
		counter++;
=======
	private int destroyedCounter = 0;
	
	void OnTriggerEnter(Collider other)
	{
		destroyedCounter++;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
		
		Destroy(other.gameObject);

        //Calls patternDrop methods to reset pattern and spawn new pattern
<<<<<<< HEAD
		if (GameObject.Find("Treadmill").GetComponent<patternDrop>().level == counter)
		{
			counter = 0;
=======
		if (GameObject.Find("Treadmill").GetComponent<patternDrop>().level == destroyedCounter)
		{
			destroyedCounter = 0;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
			GameObject.Find ("Treadmill").GetComponent<patternDrop> ().roundInSeconds = 0;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().pattern.Clear();
			GameObject.Find("Treadmill").GetComponent<patternDrop>().alreadyExists = false;
			GameObject.Find("Treadmill").GetComponent<patternDrop>().spawnPattern();
		}
	}

	public void setCounter(int c){
<<<<<<< HEAD
		this.counter = c;
=======
		destroyedCounter = c;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
	}

    public void updateCounter()
    {
<<<<<<< HEAD
        counter++;
    }
=======
        destroyedCounter++;
    }

>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
}
