using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Explosion : MonoBehaviour {

	//public InputField boreholediameter;
	public Slider minimumburden;
	public Slider density;
	public Slider wpltext;
	private float mb;
	private float d;
	private float wpl;
	private float power1;

	void Start () {
		
		d = density.minValue;
		mb = minimumburden.minValue;
		wpl = wpltext.minValue;
		power1 = (0.44f*4200)*Mathf.Sqrt(wpl/(d*mb*mb));
		Debug.Log (mb);

	}
	

	void Update () {
		if(d != density.value || mb != minimumburden.value || wpl != wpltext.value){
			MBCheck ();
			DCheck ();
			WPLCheck ();
			power1 = ((0.44f*4200)*Mathf.Sqrt(wpl/(d*mb*mb)));
			Debug.Log (power1);
		}
			
		Vector3 pos = transform.position;
		pos.z = mb;
		transform.position = pos;
	}


	void Boom ()
	{
		Collider[] col = Physics.OverlapSphere (transform.position, 10f);
		foreach (Collider hit in col) {
			Rigidbody rb = hit.GetComponent<Rigidbody> ();
			if (rb != null) {
				rb.AddExplosionForce (power1, transform.position, 10f, 0.0f, ForceMode.Impulse);
			}
		} 
		Destroy (gameObject);
	}

	public void DelayedBoom(){
		Invoke ("Boom", 3.0f);
	}

	public void MBCheck(){
		mb = minimumburden.value;
	}

	public void DCheck(){
		d = density.value;
	}

	public void WPLCheck(){
		wpl = wpltext.value;
	}

}
