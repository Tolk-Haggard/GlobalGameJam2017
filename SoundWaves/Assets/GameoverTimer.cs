using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class GameoverTimer : MonoBehaviour {
	public float timer;
	// Use this for initialization
	void Start () {
		
	}
	
	void Update () {

		timer -= Time.deltaTime;

		if (timer <=(0))
			SceneManager.LoadScene ("TitleScreen", LoadSceneMode.Single);

	}
}
