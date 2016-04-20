using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Application.LoadLevel("prefinal1");
	}
	
	// Update is called once per frame
	void Update () {
		Application.Quit();
	}
}
