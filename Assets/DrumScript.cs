using UnityEngine;
using System.Collections;

public class DrumScript : MonoBehaviour {

	public AudioClip impact;
	public Light light;
	AudioSource audio;

	void Start() {
		audio = GetComponent<AudioSource>();
	}

	void OnMouseDown()
	{
		Debug.Log ("Drum1");
		StartCoroutine ("LightFlash");
		audio.PlayOneShot(impact, 0.7F);

	}

	IEnumerator LightFlash()
	{
		light.enabled = true;
		yield return new WaitForSeconds (0.5f);
		light.enabled = false;
	}

}
