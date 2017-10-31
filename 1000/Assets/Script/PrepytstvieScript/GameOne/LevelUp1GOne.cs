using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUp1GOne : MonoBehaviour {
	public GameObject canvas;
	// тригер появляеться, стена удаляеться, -1е усложнение
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player"){
			canvas.GetComponent<SferPositionPregrada> ().enabled = true;
			Destroy (gameObject);
		}
	}
}