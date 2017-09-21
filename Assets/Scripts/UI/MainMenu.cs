using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {
    public void quitGame() {
        Application.Quit();
    }

    public void openOptions() {

    }

    public void closeOptions() {

    }

    public void startGame() {
        SceneManager.LoadScene("Main Game");
    }
}
