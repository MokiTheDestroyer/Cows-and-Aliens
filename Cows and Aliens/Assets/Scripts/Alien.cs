using UnityEngine;
using System.Collections;

public class Alien : MonoBehaviour {

	private NoCollider noCollider;
	private Boundaries bounds;
	public GameObject explosion;
	public GameObject groundParticles;
	private GroundLevel groundLevel;
	private LoseCollider loseCollider;
	private LightBeam beam;
	public int health = 100;
	private Score score;
	public int points;
	private GroundParticles instantiatedGroundParticles;
	public GameObject chickenSpawner;

	
	
	void Start(){
		groundLevel = GameObject.FindObjectOfType<GroundLevel>();
		bounds = GameObject.FindObjectOfType<Boundaries>();
		beam = GameObject.FindObjectOfType<LightBeam>();
		loseCollider = GameObject.FindObjectOfType<LoseCollider>();
		score = GameObject.FindObjectOfType<Score>();
		noCollider = GameObject.FindObjectOfType<NoCollider>();
	}
	
	public void ShineBeam(){
		beam.ShineBeam();
		Instantiate(groundParticles);
		Instantiate(chickenSpawner);
		AudioSource audio = GetComponent<AudioSource>();
		audio.Play();

	}
	
	public void DealDamage(){
		health -= 1;
		if(health <= 0){
			Instantiate(explosion);

			instantiatedGroundParticles = GameObject.FindObjectOfType<GroundParticles>();
			instantiatedGroundParticles.destroyGroundParticles();
			groundLevel.YouWin();
			score.AddScore(points);
			bounds.DestroyBoundaries();
			beam.TurnOffBeam();
			loseCollider.DestroyLoseCollider();
			noCollider.DestroyNoCollider();
			Destroy(gameObject);
		}
	}
}
