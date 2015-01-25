using UnityEngine;
using System.Collections;

public class BatterStation : MonoBehaviour {
	public AudioClip audio;
	void OnTriggerEnter2D(Collider2D other) {
				if (other.gameObject.tag == "Player") {
						Debug.Log ("Player is charged");
						Robot robot = other.gameObject.GetComponent<Robot>();
			DrainBar drainbar = other.gameObject.GetComponent<DrainBar>;
						robot.SetBatteryHealth (drainbar.getMaxBattery);
						AudioSource.PlayClipAtPoint(audio, transform.position); 
				}
		}
}
