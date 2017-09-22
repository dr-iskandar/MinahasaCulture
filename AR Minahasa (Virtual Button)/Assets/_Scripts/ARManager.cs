using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARManager : MonoBehaviour {

	public GameObject [] allMenu;
	public GameObject Menu;
	public GameObject ManualPanel, AboutPanel;
	public bool boel;
	public ARModul modul;
	public GameObject cap;
	CaptureAndSave snapShot ;

	public void StartAR(GameObject back)
	{
		boel = false;
		back.SetActive (true);
		cap.SetActive (true);
		Menu.SetActive (false);
	}

	public void Manual()
	{
		ManualPanel.SetActive (true);
	}

	public void About()
	{
		AboutPanel.SetActive (true);
	}

	public void closePanel(GameObject me)
	{
		me.SetActive (false);
	}

	public void Exit()
	{
		Application.Quit ();
	}

	public void BackToMenu(GameObject me)
	{
		Menu.SetActive (true);
		cap.SetActive (false);
		me.SetActive (false);
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

	public void Home()
	{
		Menu.SetActive (true);

		for (int i = 0; i < allMenu.Length; i++) 
		{
			allMenu [i].SetActive (false);
		}

	}

	public void watuControl1()
	{
		modul.watu1.SetActive (true);
		modul.watu2.SetActive (false);
		modul.next.SetActive (false);
		modul.prev.SetActive (true);
	}

	public void watuControl2()
	{
		modul.watu1.SetActive (false);
		modul.watu2.SetActive (true);
		modul.next.SetActive (true);
		modul.prev.SetActive (false);
	}

	public void SS()
	{
		snapShot.CaptureAndSaveToAlbum(ImageType.JPG);
	}

}
