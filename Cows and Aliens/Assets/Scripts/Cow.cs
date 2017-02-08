using UnityEngine;
using System.Collections;

public class Cow : MonoBehaviour {

	public float appearSeconds;
	
	private CowDisplay cowDisplay;
	private Rigidbody2D gravity;
	private Animator animator;
	private Score score;

	void Start(){
		cowDisplay = GameObject.FindObjectOfType<CowDisplay>();
		score = GameObject.FindObjectOfType<Score>();
		animator = GetComponent<Animator>();
		gravity = GetComponent<Rigidbody2D>();
		animator.enabled = true;
		
	}
	
	void OnCollisionEnter2D(Collision2D col){
		GameObject obj = col.gameObject;
	
		if(obj.GetComponent<LoseCollider>()){
			Invoke("DestroyCow", 0.07f);
			cowDisplay.RemoveCow();
		}
	}
	
	public void DestroyCow(){
		Destroy(gameObject);
	}
	
	public void ChangeGravity(){
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();
		animator.enabled = false;

		gravity.gravityScale = -13;
	}
	
	
	public void WinGravity(){
		gravity.gravityScale = 100;
	}
	
	public void CowPoints(){
		score.AddScore(100);
	}
}
