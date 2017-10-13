using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Dead Zone") {
            Debug.Log("Ded");
            Dead();
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Avoid At All Costs") {
            Debug.Log("Ded");
            Dead();
        }
    }

    void Dead() {
        Time.timeScale = 0;
        UIManager.instance.hasGameStarted = false;
        UIManager.instance.deactivateUI("pauzeScreen"); // Just to be sure
        UIManager.instance.activateUI("death");

    }

}
