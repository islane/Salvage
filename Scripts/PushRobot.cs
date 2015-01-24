using UnityEngine;
using System.Collections;

public class PushRobot : Robot {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			rigidBody2d.AddForce(new Vector2(-movement, 0.0f));
		}
		if (Input.GetKey(KeyCode.D))
		{
			rigidBody2d.AddForce(new Vector2(movement, 0.0f));
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			rigidBody2d.AddForce(new Vector2(0.0f, jump));
			//Debug.Log ()
		}
		if (Input.GetKeyDown(KeyCode.E))
		{
			//rigidBody2d.AddForce(new Vector2());
		}
	}
}