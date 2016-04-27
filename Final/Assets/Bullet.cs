using UnityEngine;
using System.Collections;

public class Bullet : MonoBehaviour {
	public int Force;
	public Rigidbody rb;

	// Use this for initialization
	void Start () {

		rb = GetComponent<Rigidbody>();
		rb.AddRelativeForce (Vector3.forward * Force);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
