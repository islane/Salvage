﻿using UnityEngine;
using System.Collections;

public class WallSound : MonoBehaviour {

	void OnTriggerEnter(Collider otherObj)
	{
		
		if (otherObj.tag == "player")
		{
			Debug.Log ("Hit the wall");
			audio.Play();
		}
		else {
			audio.Stop();
		}
	}
}