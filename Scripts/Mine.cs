using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {
	public AudioClip audio;
	void OnTriggerEnter2D(Collider2D other) {
		if (other.gameObject.tag == "Player"){
						Debug.Log ("Player hit the mine");
			AudioSource.PlayClipAtPoint(audio, transform.position); 
			Destroy(gameObject);
		}
		
		
	}
}