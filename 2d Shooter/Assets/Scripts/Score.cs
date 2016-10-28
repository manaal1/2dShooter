using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class Score : MonoBehaviour {

	public  int crystals = 0;
	public Text TextScore;
	// Use this for initialization
	void Start () {
		TextScore = GameObject.Find ("TxtScore").GetComponent<Text> ();
	
	}
	
	// Update is called once per frame  
	void Update () {
		TextScore.text = "Score : " + crystals;
	}
}
