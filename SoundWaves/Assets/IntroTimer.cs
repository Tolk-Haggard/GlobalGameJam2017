using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class IntroTimer : MonoBehaviour {
	public float timer = 25.0f;

	void Start () {
		
	}
	

	void Update () {

		timer -= Time.deltaTime;

		if (timer <=(0))
			SceneManager.LoadScene ("Lvl1", LoadSceneMode.Single);

	}
}
