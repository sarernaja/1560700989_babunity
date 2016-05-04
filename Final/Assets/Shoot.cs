using UnityEngine;
using System.Collections;

public class Shoot : MonoBehaviour {
	private Rigidbody rb;
	public GameObject bullet;
	public GameObject button;
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown (KeyCode.Mouse0)) {
			Instantiate(bullet,new Vector3 (-0.26f,0.77f,-1.64f),transform.rotation);
		}
	
	}
}
