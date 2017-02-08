using UnityEngine;
using System.Collections;

public class NoCollider : MonoBehaviour {

	
	public GameObject warpObject;

	void Start(){
		
	}

	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.GetComponent<Cow>()){
			Instantiate(warpObject);
			Destroy(col.gameObject);
		}
	}
	
	public void DestroyNoCollider(){
		Destroy (gameObject);
	}
}
