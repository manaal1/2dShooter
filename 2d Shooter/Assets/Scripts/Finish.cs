using UnityEngine;
using System.Collections;

public class Finish : MonoBehaviour {
	public GameObject finish;
	// Use this for initialization
	void Start () {
		finish.SetActive (false);
	}
	
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{   
			SoundEffectsHelper.Instance.MakePlayerShotSound();
			//	Destroy (other.gameObject);
			finish.SetActive(true);
		}
	}
}
