using UnityEngine;
using System.Collections;

public class Chicken : MonoBehaviour {

	


	public float appearSeconds;

	private Score score;
	private Alien alien;
	public float currentSpeed;
	

	// Use this for initialization
	void Start () {
	
		
		score = GameObject.FindObjectOfType<Score>();
		alien = GameObject.FindObjectOfType<Alien>();
	}
	
	void Update(){
		transform.Translate(Vector3.left * currentSpeed * Time.deltaTime);
	}
	
	void OnCollisionEnter2D(Collision2D col){
		if(col.gameObject.GetComponent<LoseCollider>()){
			if(alien != null){
				alien.DealDamage();
			}

			score.AddScore(100);
			Destroy(gameObject);

		}
	}
	
}
