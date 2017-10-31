using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPersGOne : MonoBehaviour {
	public GameObject Pers;

	void OnMouseUp () {

		Pers.GetComponent <Rigidbody> ().velocity = new Vector3 (0f, 4.8f, 0f);
	}
}
