using UnityEngine;
using System.Collections;

/*
* Handles the Bomb-Explosion
*/

public class ExplosionScript : MonoBehaviour {
<<<<<<< HEAD
    private GameObject bomb;
    private float waitingTime = 0.05f;
=======

    private float waitingTime = 0.05f;
    private bool destroyable = false;
    GameObject bomb;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4

    /*
	*Bomb explodes when it's touched
	*/
<<<<<<< HEAD
    void Start() {
    }
    void OnMouseDrag() {
        explosion();
    }
    void OnMouseClick() {
        explosion();
    }

    /*
	* Bomb explodes when it collides with any object
	*/
    void OnCollisionEnter(Collision collision) {

        if (collision.gameObject.CompareTag("Good")) {

            explosion();
        }

        if (collision.gameObject.CompareTag("Bad")) {

            explosion();
        }
    }


    /*
	* Bomb's collider will scale that fast it will work as explosion
	*/
    void explosion() {
        //Object turns invisible and expands rapidly
        GameObject.Find("Treadmill").GetComponent<ExplosionSound>().PlayExplosion();

        GetComponent<Renderer>().enabled = false;
        bomb = GameObject.Find("Bomb(Clone)");
        bomb.transform.localScale += new Vector3(2f, 0f, 2f);
=======
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
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4

        StartCoroutine(delayedDelete());
    }

<<<<<<< HEAD

=======
    //Delete Bomb after explosion
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
    IEnumerator delayedDelete()
    {
        yield return new WaitForSeconds(waitingTime);
        deleteBomb();
    }

    void deleteBomb()
    {
<<<<<<< HEAD
        bomb.SetActive(false);
        GameObject.Find("UltimateCollider").GetComponent<CupCounter>().updateCounter();
=======
         bomb.SetActive(false);
         GameObject.Find("UltimateCollider").GetComponent<CupCounter>().updateCounter();       
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
    }
}
