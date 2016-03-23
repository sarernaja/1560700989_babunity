using UnityEngine;
using System.Collections;

public class BallPlayer : MonoBehaviour {

	public Rigidbody rb;
	public GameObject Button;
	public GameObject PlayerDeadPrefab;
	bool readyJump;


	public void jump(){
		if (readyJump) {
			rb.velocity = new Vector3 (0, 10, 0);
		}
	}
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "floor") {
			readyJump = true;
		}
	}
	void OnCollisionExit(Collision collision) {
		if (collision.gameObject.tag == "floor") {
			readyJump = false;
		}
	}
}
