using UnityEngine;
using System.Collections;

public class _GENERATE1 : MonoBehaviour {
	public GameObject enemy;
	public GameObject player;
	// Use this for initialization
	IEnumerator Start () {
		float d = 10f;
		for(;;){
		yield return new WaitForSeconds (10f);

		GameObject s = Instantiate (enemy)as GameObject;
		s.transform.localPosition = new Vector3(player.transform.localPosition.x+d,-3f,player.transform.localPosition.z);
			d = d + 20f;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}

}
