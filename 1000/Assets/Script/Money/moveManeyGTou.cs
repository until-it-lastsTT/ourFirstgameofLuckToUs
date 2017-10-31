using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveManeyGTou : MonoBehaviour {
	private float speed = 2f; 

	void Start () {
		Destroy (gameObject, 20f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += -transform.up * speed * Time.deltaTime;
	}
}
