using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemy : MonoBehaviour {

	public float timer;
	public GameObject prefab;
	public float positionX;
	public float positionY; 
	public float positionZ; 
	private float tempTimer;


	void Start() {
		tempTimer = timer;
	}


	void Update () {

		tempTimer -= Time.deltaTime;

		if (tempTimer <= 0) {
			Instantiate (prefab,new Vector3(positionX, positionY, positionZ), Quaternion.identity); 
			tempTimer = timer;
		}
		
	}
}
