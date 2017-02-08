using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CowDisplay : MonoBehaviour {

	private Text text;
	public static int cows = 5;
	private Spawner spawner;
	private LevelManager levelManager;
	private GameObject loseLabel;
	private LoseCollider loseCollider;

	void Start(){
		text = GetComponent<Text>();
		UpdateCows();
		spawner = GameObject .FindObjectOfType<Spawner>();
		levelManager = GameObject.FindObjectOfType<LevelManager>();
		loseLabel = GameObject.Find ("YouLose");
		loseLabel.SetActive(false);
		loseCollider = GameObject.FindObjectOfType<LoseCollider>();
	}
	
	void Update(){
		UpdateCows ();
	}
	
	public void RemoveCow(){
		if(cows > 0){
			cows -= 1;
			UpdateCows();
		}
		if(cows <= 0){
			loseCollider.DestroyLoseCollider();
			spawner.DestroySpawner();
			Invoke("SetUpLoseLabel", 0.2f);
			Invoke("GoToNextLevel", 4f);
		}
	}
	
	public void AddCow(){
		cows += 1;
	}
	
	void SetUpLoseLabel(){
		loseLabel.SetActive(true);
	}
	
	void GoToNextLevel(){
		levelManager.AdsLoadlevel("LoseScreen");
	}
	
	
	
	public void UpdateCows(){
		text.text = cows.ToString();
	}
	
	public void ResetCows(){
		cows = 3;
		UpdateCows();
	}
}
