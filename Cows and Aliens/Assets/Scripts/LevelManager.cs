using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {


	private AdsManager ads;

	void Start(){
		ads = GameObject.FindObjectOfType<AdsManager>();
	}

	public void AdsLoadlevel(string name){
		ads.ShowAd();
		SceneManager.LoadScene(name); 	
	}

	public void LoadLevel(string name){
		SceneManager.LoadScene(name); 
	}


	public void AdsLoadNextLevel(){
		ads.ShowRewardedAd();
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}

	public void LoadNextLevel(){
		SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
	}
	
	
	public void QuitRequest(){
		Application.Quit();
	}
}
