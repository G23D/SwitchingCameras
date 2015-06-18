/*
Apply this script to a game object then in the inspector choose an audio file via the 
"Impact field.  Uncheck "Play On Awake" then hit the "o" key to start playing the audio.
*/
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]

public class PlaySoundKeypress : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;
	
	void Update() {
		audio = GetComponent<AudioSource> ();
//edit the "o" on Line 16 to another key such as "l" etc.	
		if (Input.GetKeyDown ("o")) {
			audio.PlayOneShot (impact, 0.7F);
		}
	}
}
