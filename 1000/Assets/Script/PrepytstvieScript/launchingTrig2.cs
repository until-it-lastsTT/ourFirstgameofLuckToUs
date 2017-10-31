using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class launchingTrig2 : MonoBehaviour {
	public GameObject Sten2;
	private float speed = 5f;
	// запускаем тригер через время после начало игры чтоб он при касании с перонажем активировал усложнения в игре
	void Start () {
		StartCoroutine (oun20 ());
	}
	
	// Update is called once per frame
	IEnumerator oun20 () {
		yield return new WaitForSeconds (10f);
		Sten2.GetComponent<Rigidbody> ().AddRelativeForce (-Sten2.transform.right * speed);
	}
}
