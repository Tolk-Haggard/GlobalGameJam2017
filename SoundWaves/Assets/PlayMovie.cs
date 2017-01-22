using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayMovie : MonoBehaviour {

	void Update(){

    ((MovieTexture)GetComponent<Renderer>().material.mainTexture).Play();


	}
}
