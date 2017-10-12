using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

	private GameObject menuBG;
	private GameObject menu;
	private	RawImage _mbg;
	private MenuBlink _mbk;

	void Start(){
		menu = GameObject.Find ("Menu");
		_mbk = GetComponent<MenuBlink>(); 
		menuBG = GameObject.Find ("MenuBG");
		_mbg = menuBG.GetComponent<RawImage>();
	}

	void Update (){
		if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape)) {
			startGame ();
		}
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}
    public void startGame() {
        UIManager.instance.deactivateUI("mainMenu");
		Time.timeScale = 1;
    }
}