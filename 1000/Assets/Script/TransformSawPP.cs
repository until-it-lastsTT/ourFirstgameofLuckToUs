using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransformSawPP : MonoBehaviour {
	public float speed = 3.5f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 100f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += -transform.right * speed * Time.deltaTime;
	}
}
