using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingTG2 : MonoBehaviour {
	public GameObject Trig1;
	private float speed = 8;
	void Start () {
		StartCoroutine (GoTrig ());
	}

	// Update is called once per frame
	IEnumerator GoTrig () {
		yield return new WaitForSeconds (5f);
		Trig1.GetComponent<Rigidbody> ().AddRelativeForce (-Trig1.transform.up * speed);
	}
}
