using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Density : MonoBehaviour {

	private GameObject[] Rocks;
	public Slider slider;
	private float value;
	void Start () {
		Rocks = GameObject.FindGameObjectsWithTag("rock"); //fill rocks array
		value = slider.value;                              //condition to check to apply MassCheck() function
		MassCheck ();                                      //assign mass to rock
	}
	void Update (){
		if(value!=slider.value){
			MassCheck ();
			value = slider.value;
		}
	}

	void MassCheck(){
		foreach (GameObject rock in Rocks) {  
			Rigidbody rb = rock.GetComponent<Rigidbody> ();  
			rb.mass = slider.value * 27; 
	}
  }
}
