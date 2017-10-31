using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GOnePregradaPosition : MonoBehaviour {
	public GameObject Pregrada1, Pregrada2, Pregrada3, Pregrada4, Pregrada5;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos1 = new Vector3 (Random.Range(8f,12f),Random.Range(4.5f, 3.75f),-5f);
			Instantiate (Pregrada1, pos1, Quaternion.Euler (0,0,0));
			Vector3 pos2 = new Vector3 (Random.Range(13.5f,15.5f),Random.Range(2f, 1.5f),-5f);
			Instantiate (Pregrada2, pos2, Quaternion.Euler (0,0,0));
			Vector3 pos3 = new Vector3 (Random.Range(9f,12.5f),Random.Range(0.25f, -0.75f),-5f);
			Instantiate (Pregrada3, pos3, Quaternion.Euler (0,0,0));
			Vector3 pos4 = new Vector3 (Random.Range(13.5f,15.5f),Random.Range(-2.25f, -2.6f),-5f);
			Instantiate (Pregrada4, pos4, Quaternion.Euler (0,0,0));
			Vector3 pos5 = new Vector3 (Random.Range(8f,12f),Random.Range(-4.5f, -4f),-5f);
			Instantiate (Pregrada5, pos5, Quaternion.Euler (0,0,0));
			yield return new WaitForSeconds (5.79f);
		}
	}
}
