using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : MonoBehaviour {

    public static PoolManager instance;

    // I was forced to use enums T_T in this while it would have been bettah to do it with strings so i can create a new pool from everywhere. Without having to add a new enum.
    private Dictionary<Objects.type, List<GameObject>> defaults = new Dictionary<Objects.type, List<GameObject>>(); // This is where i store the single prefab instances
    private Dictionary<Objects.type, List<GameObject>> pool = new Dictionary<Objects.type, List<GameObject>>(); // This is the actual pool k?
    [SerializeField] private DefaultObjects[] DefaultObjects;

	// Use this for initialization
	void Start () {
        if(PoolManager.instance != null) {
            Destroy(this);
        } else {
            instance = this;

            for (var i = 0; i < DefaultObjects.Length; i++) {
                defaults[DefaultObjects[i].objectType].Add(DefaultObjects[i].prefab);

                for(var j = 0; j < DefaultObjects[i].defaultInPool; j++) {
                    GameObject go = (GameObject)Instantiate(DefaultObjects[i].prefab, transform);
                    go.SetActive(false);
                    pool[DefaultObjects[i].objectType].Add(go);
                }
            }
        }
	}
	
	public GameObject getRandomByType(Objects.type type) {
        if(pool[type].Count == 0) {
            GameObject _go = spawnRandomByType(type);
            return _go;
        }

        int randomItem = Random.Range(0, pool[type].Count - 1);
        GameObject go = pool[type][randomItem];
        go.SetActive(true);
        return go;
    }

    public void returnToPool(Objects.type type, GameObject go) {
        go.SetActive(false);
        pool[type].Add(go);
    }

    private GameObject spawnRandomByType(Objects.type type) {
        int randomItem = Random.Range(0, defaults[type].Count - 1);
        GameObject go = (GameObject)Instantiate(defaults[type][randomItem], transform);
        go.SetActive(true);
        return go;
    }
}
