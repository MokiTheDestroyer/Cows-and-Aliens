using UnityEngine;
using System.Collections;

public class LoseCollider : MonoBehaviour {

	public GameObject warpObject;
	public GameObject explosion;
	
	private GameObject loseLabel;
	
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.GetComponent<Chicken>()){
			Instantiate(explosion);
		}
		if(col.gameObject.GetComponent<Cow>()){
			Instantiate(warpObject);
		}
	}
	

	
	public void DestroyLoseCollider(){
		Destroy(gameObject);
			
	}
}
