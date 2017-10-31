using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class selectPers : MonoBehaviour {

	public GameObject whichCube, mainCube;

	void OnMouseDown () {
		transform.localScale = new Vector3 (45f, 45f, 45f);
		if (mainCube != null) {
			mainCube.GetComponent <MeshFilter> ().mesh = GameObject.Find (whichCube.GetComponent<SaveButtons> ().nowCube).GetComponent <MeshFilter> ().mesh;
			mainCube.GetComponent <MeshRenderer> ().material = GameObject.Find (whichCube.GetComponent<SaveButtons> ().nowCube).GetComponent <MeshRenderer> ().material;
		}
		PlayerPrefs.SetString ("Now Cube", whichCube.GetComponent<SaveButtons> ().nowCube);
	}
}
