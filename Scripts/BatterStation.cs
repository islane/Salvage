using UnityEngine;
using System.Collections;

public class BatterStation : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
				if (other.gameObject.tag == "Player") {
						Debug.Log ("Player is charged");
						Robot robot = other.gameObject.GetComponent<Robot>();
						robot.SetBatteryHealth (10000);
				}
		}
}
