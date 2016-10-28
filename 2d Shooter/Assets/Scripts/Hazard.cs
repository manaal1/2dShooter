using UnityEngine;
using System.Collections;

public class Hazard : MonoBehaviour {

	private Controls player;
	public Transform start;



	void Start()
	{
		player = FindObjectOfType<Controls>();

		start = GameObject.Find ("start").transform;

	}

	void Update()
	{
		

	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{
			player.transform.position = start.position;
			MenuScript.health = MenuScript.health - 0.2f;
			other.transform.GetChild(0).gameObject.GetComponent<AudioSource>().Play();
		}
	}
}
