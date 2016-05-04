using UnityEngine;
using System.Collections;

public class Control : MonoBehaviour {

	public Rigidbody rb;
	public GameObject Gun;
	public GameObject PlayerDeadPrefab;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	
	}
	
	// Update is called once per frame
	void Update () {
		float moveHorizontal = Input.GetAxis ("Horizontal");
			float moverVertical = Input.GetAxis("Vertical");

			Vector3 movement = new Vector3(moveHorizontal,0.0f,moverVertical);
		rb.AddForce (movement);
	
	}



}
