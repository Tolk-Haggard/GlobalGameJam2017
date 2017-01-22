using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

[RequireComponent(typeof(AudioSource))]
public class CaptureMic : MonoBehaviour {

	private AudioSource aud;
	private GameObject[] cubes;
	private float[] spectrumData;
	private float originalCubeY;

	public float normalizer;

	public float speed;

	void Start () {
		aud = GetComponent<AudioSource>();
		aud.clip = Microphone.Start(null, true, 1, 11025);
		aud.loop = true;
		aud.mute = false;
		aud.Play();
		cubes = GameObject.FindGameObjectsWithTag ("Cube").OrderBy(go => go.name).ToArray();
		originalCubeY = cubes [0].transform.position.y;
		spectrumData = new float[64];
	}

	void Update () {
		aud.GetOutputData (spectrumData, 0);
		var spectrumSlicesPerCube = (spectrumData.Length / cubes.Length);

		for (var i = 0; i < cubes.Length; i++) {
			var spectrumIdx = i * spectrumSlicesPerCube;
			var magnitude = 0.0f;
			for (var j = 0; j < spectrumSlicesPerCube; j++) {
				magnitude += spectrumData [spectrumIdx + j] * normalizer;
			}

			magnitude = (float)System.Math.Round (magnitude, 2);

			var newY = originalCubeY;
			if (magnitude > 1f) {
				newY += magnitude;
			}

			var oldPosition = cubes [i].transform.position;
			cubes [i].transform.position = Vector3.MoveTowards (oldPosition, new Vector3 (oldPosition.x, newY, oldPosition.z), speed * Time.deltaTime);
		}
	}
}
