using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAnimation : MonoBehaviour {

	public Texture texture1;
	public Texture texture2;
	public Texture texture3;
	public int changeDelay;

	private Renderer rend;
	private bool forward;
	private int changeCounter;

	void Start() {
		changeCounter = 0;
		forward = true;
		rend = GetComponent<Renderer>();
	}

	void Update() {
		if (changeCounter < changeDelay) {
			changeCounter++;
		} else {
			if (rend.material.mainTexture == texture1) {
				rend.material.mainTexture = texture2;
				forward = true;
			} else if (rend.material.mainTexture == texture2) {
				if (forward) {
					rend.material.mainTexture = texture3;
				} else {
					rend.material.mainTexture = texture1;
				}
			} else { 
				rend.material.mainTexture = texture2;
				forward = false;
			}
			changeCounter = 0;
		}
	}
}
