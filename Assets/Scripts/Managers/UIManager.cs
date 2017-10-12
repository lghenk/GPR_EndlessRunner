using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour {

    public static UIManager instance;

    public GameObject deathScreen       = null;
    public GameObject deathQuitScreen   = null;
    public GameObject pauzeScreen       = null;
    public GameObject mainMenu          = null;

    private Dictionary<string, GameObject> UIS = new Dictionary<string, GameObject>();

	// Use this for initialization
	void Start () {
		if(instance == null) {
            instance = this;

            // Add UIS Here
            UIS.Add("death", deathScreen);
            UIS.Add("deathQuit", deathQuitScreen);
            UIS.Add("mainMenu", mainMenu);
            UIS.Add("pauzeScreen", pauzeScreen);

            // Since we start the game for the first time (or reload the scene we would like to open the "press any key to start" screen aka the main menu)

            activateUI("mainMenu");
            Time.timeScale = 0;
        } else {
            Debug.Log("Additional UI Manager detected... Destroying");
            Destroy(this);
        }
	}
	
	public void activateUI(string ui) {
        if (!UIS.ContainsKey(ui))
            return; // We could not find any UI with that specific name....

        UIS[ui].SetActive(true);
    }
    public void deactivateUI(string ui) {
        if (!UIS.ContainsKey(ui))
            return; // We could not find any UI with that specific name....

        UIS[ui].SetActive(false);
    }
}
