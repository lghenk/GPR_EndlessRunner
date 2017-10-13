using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraStalk : MonoBehaviour {
    // Update is called once per frame
    void Update() {
        Vector3 newPos = PlayerManager.instance.playerMovement.getCameraFixedPos();
        newPos.y = transform.position.y;
        newPos.z = transform.position.z;

        transform.position = newPos;
    }
}
