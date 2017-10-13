using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class MenuBlink : MonoBehaviour {

    public RawImage quit;
    private RawImage image;
    private bool isActive = true;

    void Start() {
        image = GetComponent<RawImage>();
        StartBlinking();
    }

    IEnumerator Blink() {
        while (true) {
            if (!isActive) {
                image.enabled = false;
                quit.enabled = true;
                yield return new WaitForSecondsRealtime(.5f);
            } else {
                image.enabled = true;
                quit.enabled = false;
                yield return new WaitForSecondsRealtime(.80f);
            }

            isActive = !isActive;
        }
    }

    void StartBlinking() {
        StopAllCoroutines();
        StartCoroutine("Blink");
    }

    public void StopBlinking() {
        StopCoroutine(Blink());
    }
}