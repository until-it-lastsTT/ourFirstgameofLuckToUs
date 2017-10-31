using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RombTouPosPr : MonoBehaviour {
	public GameObject Cube2;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos2 = new Vector3 (28f, Random.Range (0f, -3.7f), -5f);
			Instantiate (Cube2, pos2, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (47f);
		}
	}
}
