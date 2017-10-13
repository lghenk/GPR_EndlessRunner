using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    private GameObject menu;
    private MenuBlink _mbk;

    void Start() {
        menu = GameObject.Find("Menu");
        _mbk = GetComponent<MenuBlink>();
    }

    void Update() {
        if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape)) {
            UIManager.instance.hasGameStarted = true;
            startGame();
        }
        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
    public void startGame() {
        UIManager.instance.deactivateUI("mainMenu");
        Time.timeScale = 1;
    }
}