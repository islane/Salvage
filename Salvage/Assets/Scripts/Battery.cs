using UnityEngine;
using System.Collections;

public class Battery : MonoBehaviour {
	public int batteryHealth = 100;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	 
		if (Input.GetKey(KeyCode.A))
		{
			batteryHealth =-1;
		}
		if (Input.GetKey(KeyCode.D))
		{
			batteryHealth =-1;
		}
		if (Input.GetKeyDown(KeyCode.Space))
		{
			batteryHealth =-1;
		}
	}
}
