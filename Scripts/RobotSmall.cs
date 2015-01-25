using UnityEngine;
using System.Collections;

public class RobotSmall : Robot {

	//public AudioClip sound;
	//AudioSource sound;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			MoveLeft (movement);
		}
		if (Input.GetKey(KeyCode.D))
		{
			MoveRight (movement);
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			Jump (jump);
		}
		
		if (batteryHealth == 0){
			Destroy(gameObject);
		}

	}
}
