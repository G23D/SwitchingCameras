using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;
	
	void Update() {
		audio = GetComponent<AudioSource> ();
	
		if (Input.GetKeyDown ("o")) {
			audio.PlayOneShot (impact, 0.7F);
		}
	}
}
