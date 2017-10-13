using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChunkThreshold : MonoBehaviour {

    [SerializeField] [Range(-30, 30)] private int treshold = 0;
    private bool isActive = false;
	
	// Update is called once per frame
	void Update () {
		if(PlayerManager.instance.transform.position.x > transform.position.x) {
            
        }
	}

    private void OnDrawGizmosSelected() {
        Gizmos.color = Color.green;
        Gizmos.DrawLine(transform.position + new Vector3(treshold, 0, 0), transform.position + new Vector3(treshold, 10, 0));
    }
}
