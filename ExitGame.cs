using UnityEngine;
using System.Collections;

public class ExitGame : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
			}
			
			void OnTriggerEnter2D(Collider2D other) {
				
				if (other.gameObject.GetComponent<Robot>())
				{	
					Debug.Log("Player Exit");
					Application.LoadLevel("Level001");
			}
	}
}