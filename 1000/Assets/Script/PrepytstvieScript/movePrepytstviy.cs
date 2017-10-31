using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movePrepytstviy : MonoBehaviour {
	public float Speed = 2f;
	// Use this for initialization
	void Start () {
		Destroy (gameObject, 20f);
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += -transform.up * Time.deltaTime * Speed;
	}
}
