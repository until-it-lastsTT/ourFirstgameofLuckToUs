using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3UpG2 : MonoBehaviour {
	public GameObject Prepytstvie1,Prepytstvie2,Prepytstvie3,Prepytstvie4,Prepytstvie5,Prepytstvie6,Prepytstvie7;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			Prepytstvie1.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie2.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie3.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie4.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie5.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie6.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Prepytstvie7.GetComponent<movePrepytstviy> ().Speed = 4.2f;
			Destroy (gameObject);
		}
	}
}
