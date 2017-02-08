using UnityEngine;
using System.Collections;

public class Spawner : MonoBehaviour {

	public GameObject cow;
	private bool aliveSpawner = true;
	// Update is called once per frame
	void Update () {
		if(aliveSpawner){
			if(IsTimeToSpawn(cow)){
				Spawn(cow);
			}
		}
	}
	
	bool IsTimeToSpawn(GameObject cowObject){
		Cow cow = cowObject.GetComponent<Cow>();
		
		float meanSpawnDelay = cow.appearSeconds;
		float spawnsPerSecond = 1 / meanSpawnDelay;
		
		if(Time.deltaTime > meanSpawnDelay){
			Debug.LogWarning("Spawn rate capped by fram rate");
		}
		
		float threshold = spawnsPerSecond * Time.deltaTime;
		
		return(Random.value < threshold);
	}
	
	void Spawn(GameObject myCow){
		GameObject thisCow = Instantiate(myCow) as GameObject;
		thisCow.transform.parent = transform;
		thisCow.transform.position = transform.position;
	}
	
	public void DestroySpawner(){
		aliveSpawner = false;
	}
}
