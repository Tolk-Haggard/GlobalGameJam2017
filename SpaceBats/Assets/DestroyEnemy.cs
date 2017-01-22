using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DestroyEnemy : MonoBehaviour {

	public static int kills = 0;

	void OnCollisionEnter (Collision col) {
		if(col.gameObject.name.Contains("Monster")) {
			kills += 1;
			Destroy(col.gameObject);

			if (kills >= 5) {
				kills = 0;
				SceneManager.LoadScene ("GameWin", LoadSceneMode.Single);
			}
		}
	}
}