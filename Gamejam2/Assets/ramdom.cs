﻿using UnityEngine;
using System.Collections;

public class ramdom : MonoBehaviour {
	public GameObject hazard;
	public int hazardCount;
	public float spawnWait;
	public float startWait;
	public float waveWait;
	
	// Use this for initialization
	void Start () {
		Debug.Log("hit");
		StartCoroutine (SpawnWaves());
	}
	
	// Update is called once per frame
	void Update () {
	}
	public void DoPlayAgain(){
		Application.LoadLevel (0);
	}
	IEnumerator SpawnWaves()
	{
		yield return new WaitForSeconds (startWait);
		while (true) {
			for (int i = 0; i < hazardCount; i++) {
				Vector3 spawnPosition = new Vector3 (3,3,0);
				Quaternion spawnRotation = Quaternion.identity;
				GameObject hazardshoot = (GameObject)Instantiate (hazard, spawnPosition, spawnRotation);
				hazardshoot.transform.Rotate(new Vector3(0,0,90),90);
				yield return new WaitForSeconds (spawnWait);
			}
			yield return new WaitForSeconds (waveWait);
		}
	}
}