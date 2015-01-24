using UnityEngine;
using System.Collections;

public class MovableObj : MonoBehaviour {
	GameObject player;
	GameObject movableObj;
	float distance = 10.0f;

	// Use this for initialization
	void Start () {
		player = GameObject.FindWithTag("RobotPush");
		movableObj = GameObject.FindGameObjectWithTag("MovableObj");
	}
	
	// Update is called once per frame
	void Update () {
//		if (Input.GetKeyDown (KeyCode.E)) {
//			// here is the once grabbing now climbing stuff
//			distance = Vector2.Distance (this.transform.position, player.transform.position);
//			if (distance < 2) {
//				this.transform.parent = movableObj.transform;
//				this.transform.localPosition = new Vector2 (0.18f, 0.48f);
//				this.transform.localRotation = Quaternion.identity;
//			}
//		}
	}
	void OnCollisionEnter2D(Collision2D collision){
		transform.SetParent(collision.transform);
	}
}
