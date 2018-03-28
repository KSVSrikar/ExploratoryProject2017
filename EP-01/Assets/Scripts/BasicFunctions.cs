using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BasicFunctions : MonoBehaviour {

	private bool isThere = false;
	public GameObject panel;
	private bool lockCursor1;

	void Start () {
		
	}


	void Update ()
	{
		//to toggle panel menu
		if (Input.GetKeyDown(KeyCode.Tab) == true) {
			panel.SetActive(isThere);
			lockCursor1 = isThere;
			if (!lockCursor1)
			{
				Cursor.lockState = CursorLockMode.Locked;
			}
			else{
				Cursor.lockState = CursorLockMode.None;
			}
			isThere = !isThere;
		}
			
	}

	//function for refreshing scene
	public void refresh(){
		SceneManager.LoadScene (0);
	}

	//function for quitting the application
	public void quit(){
		Application.Quit ();
	}
}
