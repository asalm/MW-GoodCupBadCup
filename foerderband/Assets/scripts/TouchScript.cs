using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	private Rigidbody rb;
	private float z = 12f;
	private static Camera main;
<<<<<<< HEAD
	public int speed = 50;
    public AudioSource soundsCup;
    public AudioClip pickupSound;
=======
	public int speed = 50; 
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4

	void Start()
	{   
		main = Camera.main;
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
	}

<<<<<<< HEAD
    //play pickup sound when a cup is being picked up
    void OnMouseDown()
    {
        soundsCup = GetComponent<AudioSource>();
        soundsCup.PlayOneShot(pickupSound);
    }
    /*
	* if object is dragged by finger, the object beneath will move to new fingerposition
	*/
    void OnMouseDrag()
	{
        Vector3 v3 = Input.mousePosition;
=======
	/*
	* if object is dragged by finger, the object beneath will move to new fingerposition
	*/
	void OnMouseDrag()
	{
		Vector3 v3 = Input.mousePosition;
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4
		v3.z = z;
		//Debug.Log (v3.z);
		v3 = main.ScreenToWorldPoint(v3);

		rb.velocity = (v3 - gameObject.transform.position) * speed;
<<<<<<< HEAD
    }
=======
	}
>>>>>>> 45e5eb1f1939b23961abd22359e7e965a9fe20c4

}
