using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {

	public Robot currentRobot;
	public Robot robotSmall;
	public Robot robotJump;
	public Robot robotPush;

	//public 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Alpha1))
		{
			if(!(robotSmall.activated))
			{
				currentRobot.current = false;
				currentRobot = robotSmall;
				currentRobot.current = true;
			}
		}
		if(Input.GetKeyDown (KeyCode.Alpha2))
		{
			if(!(robotJump.activated))
			{
				currentRobot.current = false;
				currentRobot = robotJump;
				currentRobot.current = true;
			}
		}
		if (Input.GetKeyDown (KeyCode.Alpha3))
		{
			if(!(robotPush.activated)){
				currentRobot.current = false;
				currentRobot = robotPush;
				currentRobot.current = true;
			}
		}
	}
}
