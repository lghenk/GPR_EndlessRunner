using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class ScoreManager : MonoBehaviour {

	public static float score;
	Text text;

	void Awake(){
		text = GetComponent<Text>();
		score = 0;
	}

	void Start () {
		InvokeRepeating("updateScore",0.000015f, 0.000015f);
	}

	void Update(){
		text.text = "Meters: " + score;
	}

	void updateScore(){
		score++;
		Debug.Log(score);
	}

}
