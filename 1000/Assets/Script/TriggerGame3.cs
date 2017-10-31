using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerGame3 : MonoBehaviour {

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Pregrad") {
			Destroy (gameObject);
			Time.timeScale = 0;
		}
	}
}
