using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class PlyrDeadScript : MonoBehaviour {
	
	//private Controls player;


	void Start()
	{  

	}

	void Update()
	{
		
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{   
			
			MenuScript.health =MenuScript.health -0.2f;
			other.transform.GetChild(0).gameObject.GetComponent<AudioSource>().Play();

		}
	}
}
