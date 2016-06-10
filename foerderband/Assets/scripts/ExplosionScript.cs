using UnityEngine;
using System.Collections;

/*
* Handles the Bomb-Explosion
*/

public class ExplosionScript : MonoBehaviour {

    private float waitingTime = 0.05f;
    private bool destroyable = false;
    GameObject bomb;

    /*
	*Bomb explodes when it's touched
	*/
    void Start(){
	}
	void OnMouseDrag(){
		explosion ();
	}
	void OnMouseClick(){
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
		bomb = GameObject.Find("Bomb(Clone)");
		bomb.transform.localScale += new Vector3 (2f, 0f, 2f);

        StartCoroutine(delayedDelete());
    }

    //Delete Bomb after explosion
    IEnumerator delayedDelete()
    {
        yield return new WaitForSeconds(waitingTime);
        deleteBomb();
    }

    void deleteBomb()
    {
         bomb.SetActive(false);
         GameObject.Find("UltimateCollider").GetComponent<CupCounter>().updateCounter();       
    }
}
