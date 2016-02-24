using UnityEngine;
using System.Collections;

public class Mover : MonoBehaviour
{
	public float speed;
	public Rigidbody rb;
	void OnCollisionEnter(Collision collision)
	{
		if (collision.gameObject.tag == "cly") {
			rb = GetComponent<Rigidbody> ();
			rb.velocity = transform.forward * speed;
		}
		
	}
	
	
}﻿