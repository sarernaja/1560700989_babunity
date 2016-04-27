using UnityEngine;
using System.Collections;

public class menu : MonoBehaviour {

	IEnumerator OnMouseDown()
	{
		yield return new WaitForSeconds (1f);
		Debug.Log ("isClick");
		Application.LoadLevel(1);
	}
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
