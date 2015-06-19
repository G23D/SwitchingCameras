//released under the MIT license by G23D Studios-Kyle "G" www.g23d.com;
//Apply to a game object then in the inspector uncheck "PlayOnAwake" for the audio component and then for the
//script choose a sound file via the "Impact" field.
using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlaySoundKeypress : MonoBehaviour {
	public AudioClip impact;
	//http://docs.unity3d.com/ScriptReference/AudioSource.html
	AudioSource audio;
	
	void Update() {
		audio = GetComponent<AudioSource> ();
	
		if (Input.GetKeyDown ("o")) {
			audio.PlayOneShot (impact, 0.7F);
		} else {
			//http://docs.unity3d.com/ScriptReference/AudioSource.Stop.html
			audio.Stop ();
		}
	}
}
