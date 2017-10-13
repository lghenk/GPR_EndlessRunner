using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour {

    public float movementSpeed = 10f;

    private Animator animController;
    private float cameraOffset = 0;
    public Rigidbody _rb;
    private bool isJumping = false;

    // Use this for initialization
    void Start() {
        animController = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update() {
        // Set new position
        float newX = transform.position.x + movementSpeed * Time.deltaTime;
        _rb.MovePosition(new Vector3(newX, transform.position.y, transform.position.z));
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
        if (animController.GetCurrentAnimatorStateInfo(0).IsName("Start Jump") || animController.GetBool("Start Jump") || isJumping)
            return;

        isJumping = true;
        animController.ResetTrigger("Slide");
        animController.SetTrigger("Start Jump");
        _rb.AddForce(new Vector3(0, 10, 0), ForceMode.Impulse);

    }

    public void slide() {
        if (animController.GetCurrentAnimatorStateInfo(0).IsName("Sliding") || animController.GetBool("Slide"))
            return;

        animController.ResetTrigger("Start Jump");
        animController.SetTrigger("Slide");
    }

    public Vector3 getCameraFixedPos() {
        Vector3 pos = transform.position;
        pos.x += cameraOffset;
        return pos;
    }

    private void OnCollisionEnter(Collision collision) {
        if (isJumping) {
            animController.SetTrigger("End Jump");
            isJumping = false;
        }
    }
}
