using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathHandler : MonoBehaviour {

    private void OnTriggerEnter(Collider other) {
        if(other.tag == "Dead Zone") {
            Debug.Log("Ded");
            Dead();
        }
    }

    private void OnCollisionEnter(Collision collision) {
        if(collision.gameObject.tag == "Avoid At All Costs") {
            Debug.Log("Ded");
            Dead();
        }
    }

    void Dead() {
        Time.timeScale = 0;
        // TODO: Open UI 
        // - At this moment nathan knew he fuckeduo
        // - GTA Death screen
        // - To be continued

        UIManager.instance.activateUI("death");

    }

}
