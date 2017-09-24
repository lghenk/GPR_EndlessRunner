using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour {

    public static ChunkManager instance;
    private List<GameObject> currentActiveChunks = new List<GameObject>();

	// Use this for initialization
	void Start () {
		if(ChunkManager.instance != null) {
            Destroy(this);
        } else {
            instance = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
