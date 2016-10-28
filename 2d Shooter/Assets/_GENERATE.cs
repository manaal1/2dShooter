using UnityEngine;
using System.Collections;

public class _GENERATE : MonoBehaviour {
	public GameObject stone;
	public GameObject player;
	// Use this for initialization
	IEnumerator Start () {
		float d = 5f;
		for(;;){
		yield return new WaitForSeconds (1f);

		GameObject s = Instantiate (stone)as GameObject;
		s.transform.localPosition = new Vector3(player.transform.localPosition.x+d,player.transform.localPosition.y,player.transform.localPosition.z);
			d = d + 5f;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
