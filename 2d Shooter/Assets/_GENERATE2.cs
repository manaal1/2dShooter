using UnityEngine;
using System.Collections;

public class _GENERATE2 : MonoBehaviour {
	public GameObject enemy;
	public GameObject player;
	// Use this for initialization
	IEnumerator Start () {
		float d = 20f;
		for(;;){
		yield return new WaitForSeconds (20f);

		GameObject s = Instantiate (enemy)as GameObject;
		s.transform.localPosition = new Vector3(player.transform.localPosition.x+d,0f,player.transform.localPosition.z);
			d = d + 25f;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
