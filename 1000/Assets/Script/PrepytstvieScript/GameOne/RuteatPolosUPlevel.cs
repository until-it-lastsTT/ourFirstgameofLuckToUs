using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RuteatPolosUPlevel : MonoBehaviour {
	public GameObject Palka, Plus;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 posPalk = new Vector3 (30f, Random.Range(-2.1f,3.85f), -5f);
			Instantiate (Palka, posPalk, Quaternion.Euler (0, 0, 0));
			Vector3 posPlus = new Vector3 (34f, Random.Range(-3.85f, -0.5f), -5f);
			Instantiate (Plus, posPlus, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (30f);
		}
	}
}
