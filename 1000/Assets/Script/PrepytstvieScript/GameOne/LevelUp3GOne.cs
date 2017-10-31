using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp3GOne : MonoBehaviour {
	public GameObject canvas;
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			canvas.GetComponent<RuteatPolosUPlevel> ().enabled = true;
			Destroy (gameObject);
		}
	}
}
