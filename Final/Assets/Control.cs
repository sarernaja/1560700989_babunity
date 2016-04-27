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

	
	}
	void OnCollisionEnter(Collision collision) {

	}

}
