using UnityEngine;
using System.Collections;

public class endlessScene : MonoBehaviour {
	public GameObject congo;
	void OnTriggerEnter2D(Collider2D other)
	{
		if (other.tag == "Player")
		{   
			congo.SetActive (true);
			//other.gameObject.transform.localPosition = new Vector3 (-126f,1.5f,0f);
		}
	}
}
