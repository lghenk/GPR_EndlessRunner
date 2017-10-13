using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidableManager : MonoBehaviour {

    private List<GameObject> activeAvoidables = new List<GameObject>();

    [Tooltip("The X value the player has to be away from the avoidable before it return to the object pool")]
    [Range(10, 1000)]
    public int returnThreshold = 30;

    public int min, max;

    // Use this for initialization
    void Start() {
        StartCoroutine(spawnFirstAvoidable());
    }

    IEnumerator spawnFirstAvoidable() {
        if (PoolManager.instance == null || PlayerManager.instance == null)
            yield return new WaitForEndOfFrame();

        // Spawn first avoidable X units away from player
        GameObject avoidableObject = PoolManager.instance.getRandomByType(Objects.type.Avoidable);
        avoidableObject.transform.position = PlayerManager.instance.player.transform.position + new Vector3(30, 0, 0);
        activeAvoidables.Add(avoidableObject);

        // Now we have the first object we now can spawn an additional amount of objects from it.
        for (int i = 0; i < 5; i++) {
            spawnNewObjectBehind();
        }

        yield return null;
    }

    // Update is called once per frame
    void Update() {
        for (int i = 0; i < activeAvoidables.Count; i++) {
            if (PlayerManager.instance.player.transform.position.x > (activeAvoidables[i].transform.position + new Vector3(returnThreshold, 0, 0)).x) {
                GameObject go = activeAvoidables[i];
                activeAvoidables.Remove(go);
                PoolManager.instance.returnToPool(Objects.type.Avoidable, go);

                spawnNewObjectBehind();
            }
        }
    }

    void spawnNewObjectBehind() {
        Vector3 lastObject = activeAvoidables[activeAvoidables.Count - 1].transform.position; // Get the position of the object infront of the new one.
        GameObject newObject = PoolManager.instance.getRandomByType(Objects.type.Avoidable);
        newObject.transform.position = lastObject + new Vector3(Random.Range(min, max), 0, 0); // Set the postion of the new object
        activeAvoidables.Add(newObject);
    }
}
