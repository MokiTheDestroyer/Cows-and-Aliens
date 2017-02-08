using UnityEngine;
using System.Collections;

public class ChickenSpawner : MonoBehaviour {

	public GameObject chicken;
	private bool aliveSpawner = true;
	// Update is called once per frame
	void Update () {
		if(aliveSpawner){
			if(IsTimeToSpawn(chicken)){
				Spawn(chicken);
			}
		}
	}
	
	bool IsTimeToSpawn(GameObject chickenObject){
		Chicken chicken = chickenObject.GetComponent<Chicken>();
		
		float meanSpawnDelay = chicken.appearSeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if(Time.deltaTime > meanSpawnDelay){
			Debug.LogWarning("Spawn rate capped by fram rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime;
		
		return(Random.value < threshold);
	}
	
	void Spawn(GameObject myChicken){
		GameObject thisChicken = Instantiate(myChicken) as GameObject;
		//thisChicken.transform.parent = transform;
		thisChicken.transform.position = transform.position;
	}
	
	public void DestroySpawner(){
		aliveSpawner = false;
	}
}
