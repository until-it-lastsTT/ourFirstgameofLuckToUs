using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingTrig3 : MonoBehaviour {
	public GameObject Sten3;
	private float speed = 6.5f;

	void Start () {
		StartCoroutine (ounPP ());
	}

	// Update is called once per frame
	IEnumerator ounPP () {
		yield return new WaitForSeconds (3f);
		Sten3.GetComponent<Rigidbody> ().AddRelativeForce (-Sten3.transform.right * speed);
	}
}
