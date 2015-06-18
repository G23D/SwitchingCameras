/*
 * Apply this to a game object with a mesh collider to play an audio file on collision.
*/

using UnityEngine;
using System.Collections;

[RequireComponent(typeof(AudioSource))]
public class PlaySound : MonoBehaviour {
	public AudioClip impact;
	AudioSource audio;
	
	void Start() {
		audio = GetComponent<AudioSource>();
	}
	
	void OnCollisionEnter() {

		audio.PlayOneShot(impact, 0.7F);
	}
}
