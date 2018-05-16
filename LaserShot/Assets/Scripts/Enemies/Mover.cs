using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mover : MonoBehaviour {

	[SerializeField] private float  speed;

	void Awake(){
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.velocity = transform.forward * speed;
	}
}
