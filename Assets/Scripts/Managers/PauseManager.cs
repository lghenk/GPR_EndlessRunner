using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {
	private bool isPaused = false;
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) {
            if(isPaused) {
                isPaused = false;
                Time.timeScale = 1;
                Debug.Log("Game Resumed");
            } else {
                isPaused = true;
                Time.timeScale = 0;
                Debug.Log("Game Pauzed");
            }
        }
	}
}
