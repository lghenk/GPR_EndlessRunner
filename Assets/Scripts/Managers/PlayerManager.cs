using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerManager : MonoBehaviour {

    public static PlayerManager instance;
    public GameObject player;
    public PlayerMovement playerMovement;

    // Use this for initialization
    void Start() {
        if (PlayerManager.instance != null) { // I know i know.
            Destroy(this);
        } else {
            instance = this;
            player = GameObject.FindGameObjectWithTag("Player");
            playerMovement = player.GetComponent<PlayerMovement>();
        }
    }
}
