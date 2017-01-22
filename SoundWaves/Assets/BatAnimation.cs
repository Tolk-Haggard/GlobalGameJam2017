using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAnimation : MonoBehaviour {

	public Texture texture1;
	public Texture texture2;
	public int changeDelay;

	private Renderer rend;
	private int changeCounter;

	void Start() {
		changeCounter = 0;
		rend = GetComponent<Renderer>();
	}

	void Update() {
		if (changeCounter < changeDelay) {
			changeCounter++;
		} else {
			if (rend.material.mainTexture == texture1) {
				rend.material.mainTexture = texture2;
			} else {
				rend.material.mainTexture = texture1;
			}
			changeCounter = 0;
		}
	}
}
