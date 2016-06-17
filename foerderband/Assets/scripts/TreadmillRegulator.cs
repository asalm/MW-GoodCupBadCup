using UnityEngine;
using System.Collections;

public class TreadmillRegulator : MonoBehaviour {
	/*
	* this script will give every object a static speed
	*/

	private float speed = 3.0f;
	private float deltaSpeed = 0.5f;
	public float slowDownStart = 0f;
	public bool slowDownActive = false;
	
	public float publicSpeed;
	private float slowSpeed = 1f;
<<<<<<< HEAD
	public float slowDownDuration = 5;
=======
	public float slowDownDuration = 3;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
	
	void Start () {
		if (slowDownActive) {
			publicSpeed = speed;
		} else {
			publicSpeed = slowSpeed;
		}
	}
	
	void Update () {

        //Speed increases every 10 seconds if slowdown is not active
		if (!slowDownActive && GUI.timeAnz % 10 == 0)
		{
			speed += deltaSpeed * Time.deltaTime;
			publicSpeed = speed;
		}
		else if (slowDownActive)
		{
			publicSpeed = slowSpeed;
			
		}

        //End of slowDown
		if (slowDownActive && slowDownStart + slowDownDuration <= GUI.timeAnz) {
<<<<<<< HEAD
            if (slowDownDuration == 1.4f)
                slowDownDuration = 5;
=======
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
			slowDownActive = false;
			publicSpeed = speed;
		}
	}
}
