using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class LightBeam : MonoBehaviour {

	private Image image;
	
	void Start(){
		image = GetComponent<Image>();
		image.enabled = false;
	}
	
	public void ShineBeam(){
		image.enabled = true;
	}
	
	public void TurnOffBeam(){
		image.enabled = false;
	}
	
}
