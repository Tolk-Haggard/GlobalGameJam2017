using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

[RequireComponent(typeof(AudioSource))]
public class PlayGame : MonoBehaviour {

	private AudioSource aud;
	private float[] spectrumData;

	public float threshold;

	void Start () {
		aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start(null, true, 1, 11025);
		aud.loop = true;
		aud.mute = false;
		aud.Play();
		spectrumData = new float[64];
	}

	void Update () {
		var magnitude = 0.0f;
		aud.GetOutputData (spectrumData, 0);

		for (var j = 0; j < spectrumData.Length; j++) {
			magnitude += spectrumData [j];
		}

		magnitude = (float)System.Math.Round (magnitude, 2);

		if (magnitude > threshold) {
			SceneManager.LoadScene ("OpeningMovie", LoadSceneMode.Single);
		}
	}
}
