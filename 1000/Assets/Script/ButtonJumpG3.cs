using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonJumpG3 : MonoBehaviour {
	public GameObject Cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnMouseDown () {
		Cube.GetComponent <Rigidbody> ().velocity = new Vector3 (2.6f, 6.2f, 0f);
	}
}
