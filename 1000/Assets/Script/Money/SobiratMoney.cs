using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SobiratMoney : MonoBehaviour {
	public GameObject maney;
	public Text Gmaney;
	// Use this for initialization
	void OnTriggerEnter (Collider other) {
		if (other.tag == "money") {
			Destroy (other.gameObject);
			//maney.SetActive (false);
			PlayerPrefs.SetInt ("ColMoney", PlayerPrefs.GetInt ("ColMoney") + 1);
			Gmaney.text = PlayerPrefs.GetInt ("ColMoney").ToString ();
		}
	}
}
