using UnityEngine;
using System.Collections;

public class Floorscript : MonoBehaviour {

	public AudioClip impact;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
		audio.PlayOneShot(impact, 0.7F);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
