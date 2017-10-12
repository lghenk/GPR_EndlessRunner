using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	public static float score;
	public float points;


	[Header("100 equals 1 second")]
	public float seconds;

	Text text;

	void Awake(){
		text = GetComponent<Text>();
		score = 0;
	}

	void Start () {
		InvokeRepeating("updateScore", 0f , seconds / 100);
	}

	void Update(){
		text.text = "Meters: " + score;
	}

	void updateScore(){
		score = score + points;
	}

}
