using UnityEngine;
using System.Collections;

public class sttngManager : MonoBehaviour {

	public GameObject mainMenu;
	public GameObject stngObj;

	// Use this for initialization
	void Start () {

	}


	public void settingOpen()
	{
		mainMenu.SetActive (false);
		stngObj.SetActive(true);

	}
	public void settingClose()
	{
		mainMenu.SetActive (true);
		stngObj.SetActive(false);
	}
}
