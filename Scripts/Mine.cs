using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	public AudioClip audio;
	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Player hit the mine");
		AudioSource.PlayClipAtPoint(audio, transform.position); 
		Destroy(other);
	}
}