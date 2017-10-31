using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RombPositionPregrad : MonoBehaviour {

	public GameObject Cube1;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}

	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos1 = new Vector3 (20f, Random.Range (0f, 3.7f), -5f);
			Instantiate (Cube1, pos1, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (39f);
		}
	}
}
