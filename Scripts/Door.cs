using UnityEngine;
using System.Collections;

public class Door : MonoBehaviour {

	
	public Rigidbody2D rigidBody;

	void Start(){
		//rigidBody = gameObject.GetComponent<Rigidbody2D>();
	}

	public void Open(){
		gameObject.SetActive(false);
	}

	public void Close(){
		gameObject.SetActive(true);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
