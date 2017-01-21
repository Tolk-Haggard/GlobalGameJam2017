using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Death : MonoBehaviour {

	void OnCollisionEnter (Collision col) { 
		if (col.gameObject.name.Contains ("Monster")) {
			Debug.Log ("should be dying here");
			SceneManager.LoadScene("GameOver", LoadSceneMode.Single);
		}
	}
}
