using UnityEngine;
using System.Collections;

public class WaterDrop : MonoBehaviour {
	public AudioClip audio;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other) {
		//if (other.gameObject.tag == "Floor") {
			Debug.Log ("Water hit the floor");
			AudioSource.PlayClipAtPoint(audio, transform.position);
			Destroy (gameObject);
		//}
	}
}
