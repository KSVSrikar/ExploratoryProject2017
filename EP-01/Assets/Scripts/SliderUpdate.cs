using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SliderUpdate : MonoBehaviour {

	//Attached to Text component in slider

	public Slider slider;
	private Text sliderValue;

	void Start () {
		sliderValue = gameObject.GetComponent<Text>();
		sliderValue.text = "" + slider.minValue; //set minimum as default
	}
	
	// Update is called once per frame
	void Update () {
		//TextUpdate ();
	}

	public void TextUpdate(){
		sliderValue.text = "" + Mathf.Round(slider.value*100.0f)/100.0f;
	}

}
