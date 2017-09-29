using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkManager : MonoBehaviour {

    public static ChunkManager instance;
    public GameObject startChunk;
    private List<GameObject> currentActiveChunks = new List<GameObject>();

	// Use this for initialization
	void Start () {
		if(ChunkManager.instance != null) {
            Destroy(this);
        } else {
            instance = this;

            currentActiveChunks.Add(startChunk);
        }
	}
	
	// Update is called once per frame
	void Update () {
		if(PlayerManager.instance.player.transform.position.x > currentActiveChunks[currentActiveChunks.Count - 1].transform.position.x) {
            if(currentActiveChunks.Count > 2) {
                GameObject firstChunk = currentActiveChunks[0];
                currentActiveChunks.Remove(firstChunk);
                PoolManager.instance.returnToPool(Objects.type.Chunk, firstChunk);
            }

            // Get Last Chunk And Add a new chunk to the end of it
            GameObject newChunk = PoolManager.instance.getRandomByType(Objects.type.Chunk);
            newChunk.transform.position = currentActiveChunks[currentActiveChunks.Count - 1].transform.position + new Vector3(60, 0, 0);
            currentActiveChunks.Add(newChunk);
        }
	}
}
