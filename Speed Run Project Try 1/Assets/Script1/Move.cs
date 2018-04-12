using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	public float _speed;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		transform.Translate(_speed*Input.GetAxis("Vertical")*Vector3.forward);
		transform.Translate(_speed*Input.GetAxis("Horizontal")*Vector3.right);
	}
}