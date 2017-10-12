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
		Time.timeScale = 0;
	}

	void Update (){
		if (Input.anyKeyDown && !Input.GetKeyDown(KeyCode.Escape)) {
			Debug.Log ("werkt!!!!");
			startGame ();
		}
		if (Input.GetKeyDown(KeyCode.Escape)){
			Application.Quit ();
		}
	}
    public void startGame() {
		_mbg.enabled = false;
		this.enabled = false;
		Time.timeScale = 1;
    }
}