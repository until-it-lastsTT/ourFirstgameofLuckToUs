using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GTouPrep3and4 : MonoBehaviour {
	public GameObject Prepytstvie3,Prepytstvie4;

	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos3 = new Vector3 (Random.Range (-1f, 1f), (10f), -2.5f);
			Instantiate (Prepytstvie3, pos3, Quaternion.Euler (0, 0, 0));
			Vector3 pos4 = new Vector3 (Random.Range (2f, 4f), (10f), -2.5f);
			Instantiate (Prepytstvie4, pos4, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (3f);
		}
	}
}
