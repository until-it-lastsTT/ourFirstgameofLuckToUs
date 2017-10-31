using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SferPositionPregrada : MonoBehaviour {
	public GameObject Sphere1, Sphere2, Sphere3;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
				Vector3 pos1 = new Vector3 (Random.Range (18f, 16f), Random.Range (3.5f, 2.5f), -5f);
				Instantiate (Sphere1, pos1, Quaternion.Euler (0, 0, 0));
				Vector3 pos2 = new Vector3 (Random.Range (18f, 16f), Random.Range (1f, -1f), -5f);
				Instantiate (Sphere2, pos2, Quaternion.Euler (0, 0, 0));
				Vector3 pos3 = new Vector3 (Random.Range (18f, 16f), -4f, -5f);
				Instantiate (Sphere3, pos3, Quaternion.Euler (0, 0, 0));
				yield return new WaitForSeconds (42f);
		}
	}
}
