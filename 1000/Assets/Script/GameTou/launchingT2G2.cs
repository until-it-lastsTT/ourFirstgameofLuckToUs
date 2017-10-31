using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingT2G2 : MonoBehaviour {

	public GameObject Trig2;
	private float speed = 8;
	void Start () {
		StartCoroutine (GoTrig ());
	}

	// Update is called once per frame
	IEnumerator GoTrig () {
		yield return new WaitForSeconds (10f);
		Trig2.GetComponent<Rigidbody> ().AddRelativeForce (-Trig2.transform.up * speed);
	}
}
