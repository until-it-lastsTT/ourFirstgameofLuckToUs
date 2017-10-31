using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PositionPrepytstviy : MonoBehaviour {
	public GameObject Prepytstvie1,Prepytstvie2,Prepytstvie5,Prepytstvie6,Prepytstvie7;

	void Start () {
		StartCoroutine (spuwn ());
	}

	IEnumerator spuwn () {
		while (true) {
			Vector3 pos1 = new Vector3 (Random.Range(-6f,-5f),Random.Range(6f, 14f),-2.5f);
			Instantiate (Prepytstvie1, pos1, Quaternion.Euler (0,0,0));
			Vector3 pos2 = new Vector3 (Random.Range(-3f,-2f),Random.Range(6f, 14f),-2.5f);
			Instantiate (Prepytstvie2, pos2, Quaternion.Euler (0,0,0));
			Vector3 pos5 = new Vector3 (Random.Range(6f,5f),Random.Range(6f, 14f),-2.5f);
			Instantiate (Prepytstvie5, pos5, Quaternion.Euler (0,0,0));
			Vector3 pos6 = new Vector3 (Random.Range(-7.7f,-7f), Random.Range(9f, 18f),-2.5f);
			Instantiate (Prepytstvie6, pos6, Quaternion.Euler (0,0,0));
			Vector3 pos7 = new Vector3 (Random.Range(7.7f,7f), Random.Range(9f, 18f),-2.5f);
			Instantiate (Prepytstvie7, pos7, Quaternion.Euler (0,0,0));
			yield return new WaitForSeconds (4.5f);
		}
	}
}
