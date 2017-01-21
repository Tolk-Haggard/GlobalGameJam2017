using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour {
	private GameObject camera;
	public float speed;
	// Use this for initialization
	void Start () {
		camera = GameObject.Find ("Camera");
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = Vector3.MoveTowards(transform.position, camera.transform.position, speed * Time.deltaTime);	
	}
}
