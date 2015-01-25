using UnityEngine;
using System.Collections;

public class MenuManager : MonoBehaviour {

	public void OnClickMenu () {
        Application.LoadLevel("Level001");
	}

	public void OnClickQuit () {
        Application.Quit();
	}

	// Use this for initialization
	void Start () {
        Application.LoadLevel("MainMenu");
	}
	
}
