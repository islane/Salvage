using UnityEngine;
using System.Collections;

public class Mine : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		Debug.Log ("Object enter trigger");
	}
	void OnTriggerStay(Collider other){
		Debug.Log ("Object on trigger");
	}
	void OffTrigger(Collider other){
		Debug.Log ("Object off the trigger");
		}
}
