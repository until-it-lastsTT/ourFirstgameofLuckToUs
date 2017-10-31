using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class On1JumpGeme3 : MonoBehaviour {
	public GameObject JPG3;
	void OnTriggerExit (Collider other) {
		if (other.tag == "Player")
			//JPG3.SetActive(false);
			JPG3.GetComponent<BoxCollider>().enabled =false;
	}
	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player")
			//JPG3.SetActive (true);
			JPG3.GetComponent<BoxCollider>().enabled =true;
	}
}
