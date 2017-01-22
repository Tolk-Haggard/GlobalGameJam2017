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
			var offset = Random.Range (-15.0f, 15.0f);
			Instantiate (prefab,new Vector3(positionX + offset, positionY, positionZ), Quaternion.identity); 
			tempTimer = timer;
		}
		
	}
}
