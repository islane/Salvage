using UnityEngine;
using System.Collections;

public class water : MonoBehaviour {

	void OnTriggerEnter2D(Collider2D other) {
		Debug.Log ("Player hit the mine"); 
		Destroy(other);
	}
}
