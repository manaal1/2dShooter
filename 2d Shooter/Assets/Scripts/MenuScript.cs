using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MenuScript : MonoBehaviour {
	public GameObject gameover;
	public static float health;
	public Image bar;
	// Use this for initialization
	void Start () {
		health = 1f;
	}
	
	// Update is called once per frame
	void Update () {
		bar.fillAmount = health;
	
		if(health<=0F){
			gameover.SetActive(true);
		}
	}

	public void PlayGame()
	{
		Application.LoadLevel (3);

	}
	public void PlayGamesss()
	{
		Application.LoadLevel (2);

	}
	public void MENU()
	{
		Application.LoadLevel (1);

	}
	public void Exit()
	{
		#if UNITY_EDITOR
		UnityEditor.EditorApplication.isPlaying = false;
		#else
		Application.Quit();
		#endif
	}
}
