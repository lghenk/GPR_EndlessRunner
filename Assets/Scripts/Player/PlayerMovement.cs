using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 10f;
    public static PlayerMovement instance;


    private Animator animController;
    private float cameraOffset = 0;

	// Use this for initialization
	void Start () {
		if(PlayerMovement.instance != null) {
            Destroy(this); // We can only have one player in our scene. And to make it easier to access for other classes we made it a singleton.
        } else {
            instance = this;

            animController = GetComponent<Animator>();
        }
	}
	
	// Update is called once per frame
	void Update () {
        // Set new position
        float newX = transform.position.x + movementSpeed * Time.deltaTime;
        transform.position = new Vector3(newX, transform.position.y, transform.position.z);
    }

    public void moveLeft() {
        cameraOffset += .1f;
        if (cameraOffset > 10) {
            cameraOffset = 10;
        }
    }

    public void moveRight() {
        cameraOffset -= .1f;
        if (cameraOffset < 0) {
            cameraOffset = 0;
        }
    }

    public void jump() {
        if (animController.GetCurrentAnimatorStateInfo(0).IsName("Start Jump") || animController.GetBool("Start Jump") || animController.IsInTransition(0))
            return;

        animController.ResetTrigger("Slide");
        animController.SetTrigger("Start Jump");
    }

    public void slide() {
        if (animController.GetCurrentAnimatorStateInfo(0).IsName("Sliding") || animController.GetBool("Slide") || animController.IsInTransition(0))
            return;

        animController.ResetTrigger("Start Jump");
        animController.SetTrigger("Slide");
    }

    public Vector3 getCameraFixedPos() {
        Vector3 pos = transform.position;
        pos.x += cameraOffset;
        return pos;
    }
}
