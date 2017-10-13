using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PauseManager : MonoBehaviour {

    public bool isPaused = false;

    void Update() {
        if (Input.GetKeyDown(KeyCode.Escape) && UIManager.instance.hasGameStarted) {
            if (!isPaused) {
                UIManager.instance.activateUI("pauzeScreen");
                isPaused = true;
                Time.timeScale = 0;
            } else {
                UIManager.instance.deactivateUI("pauzeScreen");
                isPaused = false;
                Time.timeScale = 1;
            }
        }
    }
}
