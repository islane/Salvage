using UnityEngine;
using System.Collections;

public class MovableObj : MonoBehaviour {
	GameObject player;
	GameObject movableObj;


	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("RobotPush");
		movableObj = GameObject.FindGameObjectWithTag("MovableObj");
	}
	
	// Update is called once per frame
	void Update () {
		//below is hackish attempt to make the obj follow the pushreboot

	}
	void OnCollisionEnter2D(Collision2D collision){
		transform.SetParent(collision.transform);
	}
}
