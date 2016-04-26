using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	IEnumerator OnMouse()
	{
		yield return new WaitForSeconds (1f);
		Debug.Log ("isClick");
		Application.LoadLevel(0);
	}
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {

	}
}
