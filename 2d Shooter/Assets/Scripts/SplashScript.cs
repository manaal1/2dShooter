using UnityEngine;
using System.Collections;

public class SplashScript : MonoBehaviour {

	
	// Update is called once per frame
	IEnumerator Start () {

		yield return new WaitForSeconds (0.5f);
			Application.LoadLevel (1);

	
	}
}
