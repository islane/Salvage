using UnityEngine;
using System.Collections;

public class Global : MonoBehaviour {

	public Robot currentRobot;

	public Robot robotSmall;
	public Robot robotJump;

	//public 
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if(Input.GetKeyDown (KeyCode.Alpha1))
		{
			if(robotSmall.activated)
			{
				currentRobot.activated = false;
				currentRobot = robotSmall;
				currentRobot.activated = true;
			}
		}

		
		if(Input.GetKeyDown (KeyCode.Alpha2))
		{
			if(robotJump.activated)
			{
				currentRobot.activated = false;
				currentRobot = robotJump;
				currentRobot.activated = true;
			}
		}
	}
}
