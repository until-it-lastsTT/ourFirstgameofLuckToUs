using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPers : MonoBehaviour {

	public GameObject whichCube, selectBtn, mainCube;

	void OnMouseDown () {
		transform.localScale = new Vector3 (45f, 45f, 45f);
		if (PlayerPrefs.GetInt ("ColMoney") >= 1) {
		    PlayerPrefs.SetString (whichCube.GetComponent<SaveButtons> ().nowCube, "Open");
		    PlayerPrefs.SetString ("Now Cube", whichCube.GetComponent<SaveButtons> ().nowCube);
			PlayerPrefs.SetInt ("ColMoney", PlayerPrefs.GetInt ("ColMoney") - 1);
		    mainCube.GetComponent<MeshFilter> ().mesh = GameObject.Find (whichCube.GetComponent<SaveButtons> ().nowCube).GetComponent<MeshFilter> ().mesh;
		    mainCube.GetComponent<MeshRenderer> ().material = GameObject.Find (whichCube.GetComponent<SaveButtons> ().nowCube).GetComponent<MeshRenderer> ().material;
		    selectBtn.SetActive (true);
		    gameObject.SetActive (false);
		}
	}
}
