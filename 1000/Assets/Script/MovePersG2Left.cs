using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovePersG2Left : MonoBehaviour {
	public GameObject Pers;
	//private float speed = 210;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void OnMouseUp () {
		//Pers.transform.position += -transform.right * Time.deltaTime * speed;
		//Pers.GetComponent <Rigidbody> ().AddForce (-transform.right * speed);
		Pers.GetComponent <Rigidbody> ().velocity = new Vector3 (-6.75f, 0f, 0f);
	}
}
