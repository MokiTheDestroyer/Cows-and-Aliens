using UnityEngine;
using System.Collections;

public class GroundLevel : MonoBehaviour {
	
	private LevelManager levelManager;
	
	private GameObject winLabel;
	
	void Start(){
		winLabel = GameObject.Find("YouWin");
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		
		winLabel.SetActive(false);
		
	}
	
	
	public void YouWin(){

		Invoke("SetUpWinLabel", 0.2f);
		Invoke("GoToNextLevel", 4f);
	}
	
	void GoToNextLevel(){
		levelManager.LoadNextLevel();
	}
	
	void SetUpWinLabel(){
		winLabel.SetActive(true);
	}
}
