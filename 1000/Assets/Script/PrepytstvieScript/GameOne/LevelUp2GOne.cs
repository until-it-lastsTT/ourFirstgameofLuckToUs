using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp2GOne : MonoBehaviour {
	public GameObject canvas;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			canvas.GetComponent<RombPositionPregrad> ().enabled = true;
			canvas.GetComponent<RombTouPosPr> ().enabled = true;
			Destroy (gameObject);
		}
	}
}
