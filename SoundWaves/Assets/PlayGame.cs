using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class PlayGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	

	void Update () {
	
		if (Input.GetKeyDown("space"))
			SceneManager.LoadScene ("OpeningMovie", LoadSceneMode.Single);
	}
}
