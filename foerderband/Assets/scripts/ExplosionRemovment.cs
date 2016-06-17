using UnityEngine;
using System.Collections;

public class ExplosionRemovment : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Bomb(Clone)") {
<<<<<<< HEAD
          //  Debug.Log("Removed!");
=======
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
            Destroy(other.gameObject.GetComponent<ExplosionScript>());
			//other.gameObject.GetComponent<ExplosionScript>().enabled = false;
		}
	}
}
