using UnityEngine;
using System.Collections;

public class loadingScript : MonoBehaviour {

//	public string sceneToLoad;
	public float delayTime = 3f;
	IEnumerator Start () {
		yield return new WaitForSeconds (delayTime);
		Application.LoadLevel (3);
	}

}
