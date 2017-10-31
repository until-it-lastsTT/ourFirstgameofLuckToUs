using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RightMovePersG2 : MonoBehaviour {
	public GameObject Pers;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseUp () {
		Pers.GetComponent <Rigidbody> ().velocity = new Vector3 (6.75f, 0f, 0f);

	}
}
