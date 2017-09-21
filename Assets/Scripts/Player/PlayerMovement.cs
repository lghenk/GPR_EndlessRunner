using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 10f;
    public static PlayerMovement instance;

    private float cameraOffset = 10;

	// Use this for initialization
	void Start () {
		if(PlayerMovement.instance != null) {
            Destroy(this); // We can only have one player in our scene. And to make it easier to access for other classes we made it a singleton.
        } else {
            instance = this;
        }
	}
	
	// Update is called once per frame
	void Update () {
        // Set new position
        float newX = transform.position.x + movementSpeed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);


        //TODO: Refactor this code to make it SR (eg. Event Based)
        if(Input.GetKey(KeyCode.RightArrow)) {
            cameraOffset -= .1f;
            if(cameraOffset < 0) {
                cameraOffset = 0;
            }
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            cameraOffset += .1f;
            if (cameraOffset > 10) {
                cameraOffset = 10;
            }
        }
    }

    public Vector3 getCameraFixedPos() {
        Vector3 pos = transform.position;
        pos.x += cameraOffset;
        return pos;
    }
}
