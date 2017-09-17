using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour {

	public GameObject Menu;
	public bool boel;

	public void StartAR()
	{
		boel = false;
		Menu.SetActive (false);

	}

	public void Exit()
	{
		Application.Quit ();
	}

	void Update()
	{
		if (Input.GetKey(KeyCode.Escape)) 
		{
			if (boel == true) {
				Application.Quit ();
			} else {
				boel = true;
				Menu.SetActive (true);
			}
		}
	}
}
