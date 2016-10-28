using UnityEngine;
using System.Collections;

public class Crystals : MonoBehaviour {

//	private Controls player;
//	public AudioSource bling;

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.name == "rushdy")
		{   
			other.gameObject.GetComponent<AudioSource>().Play();
			GameObject.Find ("Canvas").GetComponent<Score> ().crystals++;
			Destroy(gameObject);
	
		}
	}
}
