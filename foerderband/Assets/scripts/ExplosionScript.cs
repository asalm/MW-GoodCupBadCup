using UnityEngine;
using System.Collections;

/*
* Handles the Bomb-Explosion
*/

public class ExplosionScript : MonoBehaviour {

	/*
	*Bomb explodes when it's touched
	*/
	void OnMouseDrag(){
		explosion ();
	}

	/*
	* Bomb explodes when it collides with any object
	*/
	void OnCollisionEnter(Collision collision){
		
		if(collision.gameObject.CompareTag("Good")){
			explosion();
		}

		if (collision.gameObject.CompareTag ("Bad")) {
			explosion();
		}
	}


	/*
	* Bomb's collider will scale that fast it will work as explosion
	*/
	void explosion(){
		//Object turns invisible and expands rapidly
		GetComponent<Renderer>().enabled = false;
		GameObject explosion = GameObject.Find("Bomb(Clone)");
		explosion.transform.localScale += new Vector3 (2f, 0f, 2f);
	}
}
