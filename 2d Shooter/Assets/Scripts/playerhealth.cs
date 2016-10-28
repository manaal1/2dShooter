using UnityEngine;
using System.Collections;

public class playerhealth : MonoBehaviour {
	public GameObject particle;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void OnTriggerEnter2D(Collider2D other){

		if(other.gameObject.tag=="enemy"){
			GameObject.Find ("Canvas").GetComponent<Score> ().crystals++;
			Instantiate(particle,other.transform.localPosition,other.transform.localRotation);
		    Destroy (other.gameObject);
		}
}
}
