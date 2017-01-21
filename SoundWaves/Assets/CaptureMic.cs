using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class CaptureMic : MonoBehaviour {

	private AudioSource aud;
	private GameObject[] cubes;

	// Use this for initialization
	void Start () {
		aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start(null, true, 1, 11025);
		aud.loop = true;
		aud.mute = false;
		aud.Play();
		cubes = GameObject.FindGameObjectsWithTag ("Cube");
	}
	
	// Update is called once per frame
	void Update () {
		var spectrum = new float[64];
		aud.GetSpectrumData(spectrum, 0, FFTWindow.BlackmanHarris);

		for (var i = 0; i < cubes.Length; i++) {
			var spectrumIdx = i * 3;
			var magnitude = (spectrum [spectrumIdx] + spectrum [spectrumIdx + 1] + spectrum [spectrumIdx + 2]) * 100;
			var oldPosition = cubes [i].transform.position;
			if (magnitude > .1) {
				cubes [i].transform.position = new Vector3 (oldPosition.x, magnitude, oldPosition.z);
			} else {
				cubes [i].transform.position = new Vector3 (oldPosition.x, -1, oldPosition.z);
			}
		}
	}
}
