using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	public float speed = 5.0f;
	GameObject currentCharacter;

	// Use this for initialization
	void Start () {
		Global global = GameObject.Find ("Global").GetComponent<Global>();
		currentCharacter = global.currentRobot.gameObject;
	}
	
	// Update is called once per frame
	void Update () {
		//Vector2 robotPosition = currentCharacter.transform.position;
		//transform.position = new Vector3(robotPosition.x, robotPosition.y, 0.0f);//Vector2.Lerp(transform.position, robotPosition, Time.deltaTime * speed); 
	}
}
