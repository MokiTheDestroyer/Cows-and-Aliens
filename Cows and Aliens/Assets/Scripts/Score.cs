using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class Score : MonoBehaviour {
	
	private Text textScore;
	private static float score;
	
	
	
	// Use this for initialization
	void Start () {
		textScore = GetComponent<Text>();
		UpdateScore();
	}
	
	public void AddScore(float amount){
		score += amount;
		UpdateScore();
	}
	
	public void UpdateScore(){
		textScore.text = score.ToString();
	}
	
	public void ResetScore(){
		score = 0;
		UpdateScore ();
	}
}
