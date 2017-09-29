using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

	private bool isPaused = false;
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.Escape) && !isPaused) {
			isPaused = true;
			Time.timeScale = 0;
		} else {
			isPaused = false;
			Time.timeScale = 1;
		}
	}
}
