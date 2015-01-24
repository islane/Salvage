using UnityEngine;
using System.Collections;

public class JumpPad : MonoBehaviour {

	public float bounce = 500; 

	void OnTriggerEnter(Collider other)
	{
		Debug.Log ("Bounce!");
		other.rigidbody2D.AddForce (new Vector2(0.0f, bounce));
	}
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
