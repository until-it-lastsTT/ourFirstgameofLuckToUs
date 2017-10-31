using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sbormaneyG1 : MonoBehaviour {
	public Text ManeyG1;

	void OnTriggerEnter (Collider other) {
		if (other.tag == "money") {
			Destroy (other.gameObject);
			PlayerPrefs.SetInt ("chisloMn", PlayerPrefs.GetInt ("chisloMn") + 1);
			ManeyG1.text = PlayerPrefs.GetInt ("chisloMn").ToString ();
		}
	}
}
