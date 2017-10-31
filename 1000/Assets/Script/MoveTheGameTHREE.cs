using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveTheGameTHREE : MonoBehaviour {
	//public GameObject Pers;
	private float force = 0.35f;

	void Update () {
		transform.position += transform.right * force * Time.maximumDeltaTime;
	}
}
