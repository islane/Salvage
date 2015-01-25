using UnityEngine;
using System.Collections;

public class Robot : MonoBehaviour {
	
	public Rigidbody2D rigidBody2d;

	public float movement = 10.0f;
	public float jump = 300.0f;
	public int batteryHealth = 100;
	public bool activated = false;

	public bool current = false;
	
	// Use this for initialization
	public void SetBatteryHealth(int health){
		batteryHealth = health;
	}



	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {


		if(current)
		{
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
				Jump(jump);
			}

			if (batteryHealth == 0){
				Death();
			}

		}
	}

	virtual public void MoveRight(float move)
	{
		rigidBody2d.AddForce(new Vector2(-movement, 0.0f));
		Vector2 scale = transform.localScale;
		scale.x *= -1;
		transform.localScale = scale;
		
		batteryHealth -= 1;

	}

	virtual public void MoveLeft(float move)
	{
		rigidBody2d.AddForce(new Vector2(movement, 0.0f));
		
		Vector2 scale = transform.localScale;
		scale.x *= 1;
		transform.localScale = scale;
		
		batteryHealth -= 1;

	}
	virtual public void Jump(float jump)
	{
		rigidBody2d.AddForce(new Vector2(0.0f, jump));
		batteryHealth -= 1;

	}

	virtual public void Damage(float dmg)
	{

	}

	virtual public void Death()
	{

	}
}
