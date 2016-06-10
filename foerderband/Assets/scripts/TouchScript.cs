﻿using UnityEngine;
using System.Collections;

public class TouchScript : MonoBehaviour {

	private Rigidbody rb;
	private float z = 13f;
	private static Camera main;
	public int speed = 50; 

	void Start()
	{   
		main = Camera.main;
		rb = GetComponent<Rigidbody> ();
		rb.freezeRotation = true;
	}

	/*
	* if object is dragged by finger, the object beneath will move to new fingerposition
	*/
	void OnMouseDrag()
	{
		Vector3 v3 = Input.mousePosition;
		v3.z = z;
		//Debug.Log (v3.z);
		v3 = main.ScreenToWorldPoint(v3);

		rb.velocity = (v3 - gameObject.transform.position) * speed;
	}

}
