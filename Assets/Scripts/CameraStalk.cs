using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStalk : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 newPos = PlayerMovement.instance.getCameraFixedPos();
        newPos.y = transform.position.y;
        newPos.z = transform.position.z;

        transform.position = newPos;
	}
}
