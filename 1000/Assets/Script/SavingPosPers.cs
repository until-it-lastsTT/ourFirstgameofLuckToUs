using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SavingPosPers : MonoBehaviour {
	public GameObject player;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			//player.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
			PlayerPrefs.SetFloat ("PositionX", player.transform.position.x);
			PlayerPrefs.SetFloat ("PositionY", player.transform.position.y);
			PlayerPrefs.SetFloat ("PositionZ", player.transform.position.z);
		}
	}
	void Start () {
		player.transform.position = new Vector3 (PlayerPrefs.GetFloat ("PositionX"), PlayerPrefs.GetFloat ("PositionY"), PlayerPrefs.GetFloat ("PositionZ"));
	}
}

