using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class maneyGameTou : MonoBehaviour {
	public GameObject Maney15y, Maney25y;
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos1 = new Vector3  (-6.5f, 15f, -2.5f);
			Instantiate (Maney15y, pos1, Quaternion.Euler (0, 0, 0));
			Vector3 pos2 = new Vector3 (6.5f, 25f, -2.5f);
			Instantiate (Maney25y, pos2, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (12f);
		}
	}
}
