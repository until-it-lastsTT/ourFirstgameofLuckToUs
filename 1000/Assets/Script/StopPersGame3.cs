using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StopPersGame3 : MonoBehaviour {
	public GameObject Cube;

	void OnMouseDown () {
		Cube.gameObject.GetComponent<MoveTheGameTHREE> ().enabled = false;
	}
	void OnMouseUp () {
		Cube.gameObject.GetComponent<MoveTheGameTHREE> ().enabled = true;
	}
}
