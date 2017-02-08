using UnityEngine;
using System.Collections;

public class Timer : MonoBehaviour {

	private Score score;
	private float timer = 0.0f;
	
	void Start(){
		score = GameObject.FindObjectOfType<Score>();
	}
	
	void Update(){
		timer += Time.deltaTime;
		if(timer > 10f)
		{
			score.AddScore(10f);
			timer -= 7.0f;
			score.UpdateScore();
		}
		
	}
}
