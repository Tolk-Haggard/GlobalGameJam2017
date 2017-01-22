using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	private GameObject gameCamera;
	public float speed;
    
	void Start () {
		gameCamera = GameObject.Find ("Camera");
	}

	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, gameCamera.transform.position, speed * Time.deltaTime);
	}

}
