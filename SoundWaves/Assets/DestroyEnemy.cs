using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyEnemy : MonoBehaviour {

	void OnCollisionEnter (Collision col)
	{
		if(col.gameObject.name.Contains("Monster"))
		{
			Destroy(col.gameObject);
		}
	}
}
