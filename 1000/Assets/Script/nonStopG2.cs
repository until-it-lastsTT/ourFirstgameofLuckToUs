using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nonStopG2 : MonoBehaviour {
	public GameObject Pregrada, Player;
	// Use this for initialization
	void Start () {
		StartCoroutine (spuwn ());
	}
	
	// Update is called once per frame
	IEnumerator spuwn () {
		while (true) {
			Vector3 pos1 = new Vector3 (Player.transform.position.x, Player.transform.position.y+10f, Player.transform.position.z);
			Instantiate (Pregrada, pos1, Quaternion.Euler (0, 0, 0));
			yield return new WaitForSeconds (18f);
		}
	}
}
