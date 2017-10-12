using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScreen : MonoBehaviour {
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Return)) {
            SceneManager.LoadScene("Main Game"); // Simply reload the scene. Easiest way to restart the game innit?
        } else if(Input.GetKeyDown(KeyCode.Escape)) {
            UIManager.instance.activateUI("deathQuit");
            UIManager.instance.deactivateUI("death");
        }
	}
}
