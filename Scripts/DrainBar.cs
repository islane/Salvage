using UnityEngine;
using System.Collections;

public class DrainBar : MonoBehaviour {

	float currentGraphScale = 1.0f;//draining speed vs bar drain speed
	float drainRate;
	float maxBattery;//scales depending on the robot in use
	float currentBattery;

	// Use this for initialization
	void Start () {
		if (!(GameObject.FindGameObjectsWithTag ("RobotPush") == null)) {
			drainRate = 0.0005f;//whatever the appropriate drain rate is here
			maxBattery = 100.0f;//Again, whatever the battery is for the particular bot
		}
		if (!(GameObject.Find("RobotSmall") == null)) {
			drainRate = 0.0005f;//whatever the appropriate drain rate is here
			maxBattery = 100.0f;//Again, whatever the battery is for the particular bot
		}
		if (!(GameObject.Find("JumpRobot") == null)) {
			drainRate = 0.0005f;//whatever the appropriate drain rate is here
			maxBattery = 100.0f;//Again, whatever the battery is for the particular bot
		}
	}
	// Update is called once per frame
	void Update () {
		drainBattery();
	}
	public void OnGUI(){
		GUI.backgroundColor = Color.yellow;
		GUI.Button(new Rect(10, 40, 100 * currentGraphScale, 20), "Energy");
	}
	public void drainBattery(){
		currentBattery -= drainRate;
		currentGraphScale = currentBattery * maxBattery;
	}
}
