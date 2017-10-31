using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveButtons : MonoBehaviour {

	[HideInInspector]
	public string nowCube;
	public GameObject selectCubeS,selectSphere, Open, Open2;

	void Start () {
		if (PlayerPrefs.GetString ("cube") != ("Open"))
			PlayerPrefs.SetString ("cube", "Open");
	}
	void OnTriggerEnter (Collider other) {
		other.transform.localScale = new Vector3 (1.5f, 1.5f, 1.5f);
		nowCube = other.gameObject.name;
		if (PlayerPrefs.GetString (other.gameObject.name) == "Open") {
			selectCubeS.SetActive (false);
			Open.SetActive (true);
			selectSphere.SetActive (false);
			Open2.SetActive (true);
		} else {
			selectCubeS.SetActive (true);
			Open.SetActive (false);
			selectSphere.SetActive (true);
			Open2.SetActive (false);
		}
	}
}
