using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour {

    public UnityEvent jump = new UnityEvent();
    public UnityEvent left = new UnityEvent();
    public UnityEvent right = new UnityEvent();
    public UnityEvent shift = new UnityEvent();
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown(KeyCode.Space)) {
            jump.Invoke();
        }

        if (Input.GetKey(KeyCode.LeftArrow)) {
            left.Invoke();
        }

        if (Input.GetKey(KeyCode.RightArrow)) {
            right.Invoke();
        }

        if (Input.GetKeyDown(KeyCode.LeftShift)) {
            shift.Invoke();
        }
    }
}
