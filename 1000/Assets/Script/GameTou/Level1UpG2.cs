using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1UpG2 : MonoBehaviour {
	public GameObject Prepytstvie1,Prepytstvie2,Prepytstvie3,Prepytstvie4,Prepytstvie5,Prepytstvie6,Prepytstvie7;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Prepytstvie1.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie2.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie3.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie4.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie5.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie6.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Prepytstvie7.GetComponent<movePrepytstviy> ().Speed = 3.25f;
			Destroy (gameObject);
		}
	}
}
