using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingTrig1 : MonoBehaviour {
	private float speed = 20;
	public GameObject Sten;
	// Use this for initialization
	void Start () {
		StartCoroutine (oun ());
	}
	
	// Update is called once per frame
	IEnumerator oun () {
		yield return new WaitForSeconds (5f);
		Sten.GetComponent <Rigidbody> ().AddRelativeForce (-Sten.transform.right * speed);
	}
}
