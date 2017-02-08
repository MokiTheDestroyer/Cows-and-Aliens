using UnityEngine;
using System.Collections;

public class ResetScore : MonoBehaviour {

	private Score score;
	private CowDisplay cows;

	// Use this for initialization
	void Start () {
		score = GameObject.FindObjectOfType<Score>();
		score.ResetScore();
		cows = GameObject.FindObjectOfType<CowDisplay>();
		cows.ResetCows();
	}
	
	
}
