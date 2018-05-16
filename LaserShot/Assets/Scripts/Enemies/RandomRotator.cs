using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomRotator : MonoBehaviour {
	[SerializeField] private float tumble;

	void Awake()
	{
		Rigidbody rigidbody = GetComponent<Rigidbody>();
		rigidbody.angularVelocity = Random.insideUnitSphere * tumble; 
	}
}
