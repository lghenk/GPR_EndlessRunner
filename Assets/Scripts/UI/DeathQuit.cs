using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathQuit : MonoBehaviour {

    private AudioSource _as;

    public AudioClip staticNoice;
    public AudioClip babyCry;

    public GameObject staticScreen;
    public GameObject babyScreen;


    // Use this for initialization
    void Start() {
        babyScreen.SetActive(false);
        _as = GetComponent<AudioSource>();
        _as.clip = staticNoice;
        _as.Play();
        StartCoroutine("EndItAll");
    }

    IEnumerator EndItAll() {
        yield return new WaitForSecondsRealtime(2f);
        staticScreen.SetActive(false);
        babyScreen.SetActive(true);
        _as.clip = babyCry;
        _as.Play();

        yield return new WaitForSecondsRealtime(3f);
        Application.Quit();
    }
}
