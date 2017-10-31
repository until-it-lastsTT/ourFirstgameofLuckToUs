using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespavnMnG1 : MonoBehaviour {
	public GameObject Maney, Maneydown;
	public static int count_block;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			if (count_block % 2 == 0) {
				Vector3 pos6 = new Vector3 (8f,3.6f,-5f);
				Instantiate (Maney, pos6, Quaternion.Euler (0,0,0));
				Vector3 pos7 = new Vector3 (14f,-3.6f,-5f);
				Instantiate (Maneydown, pos7, Quaternion.Euler (0,0,0));
				yield return new WaitForSeconds (70f);
			}
		}
	}
}
