﻿using UnityEngine;
using System.Collections;

public class DoubleJumpRobot : Robot{
	public float djump = 500.0f;
	public Rigidbody2D rigidBody2D;
	// Use this for initialization
	void Start () {

	}
	
	// Update is0 called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.A))
		{
			rigidBody2d.AddForce(new Vector2(-movement, 0.0f));
		}
		if (Input.GetKey(KeyCode.D))
		{
			rigidBody2d.AddForce(new Vector2(movement, 0.0f));
		}
		if (Input.GetKeyDown(KeyCode.Space)){
			rigidBody2d.AddForce(new Vector2(0.0f, djump));
			audio.Play();
		}

	}
}


