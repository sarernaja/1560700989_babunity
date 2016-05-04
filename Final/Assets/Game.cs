using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Game : MonoBehaviour {
	public GameObject PlayerDeadPrefab;
	public Rigidbody rb;
	public GameObject Scrollbar;
	public GameObject Button;
	public GameObject Button1;
	
	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
		Scrollbar.SetActive(false);
		Button.SetActive (false);
		Button1.SetActive (false);
	}

	// Update is called once per frame
	void Update () {


	}

	void OnCollisionEnter(Collision collision) {
		if (collision.gameObject.tag == "Dead") {
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
			Scrollbar.SetActive(true);
			Button.SetActive (true);
			Button1.SetActive (true);
		}
		if (collision.gameObject.tag == "Point") {
			Instantiate(PlayerDeadPrefab,this.gameObject.transform.position,Quaternion.identity);
			Destroy (this.gameObject);
		}
			
	}


}
