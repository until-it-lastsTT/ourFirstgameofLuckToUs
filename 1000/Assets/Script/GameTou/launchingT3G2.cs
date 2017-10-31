using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingT3G2 : MonoBehaviour {

	public GameObject Trig3;
	private float speed = 8;
	void Start () {
		StartCoroutine (GoTrig ());
	}

	// Update is called once per frame
	IEnumerator GoTrig () {
		yield return new WaitForSeconds (16f);
		Trig3.GetComponent<Rigidbody> ().AddRelativeForce (-Trig3.transform.up * speed);
	}
}
