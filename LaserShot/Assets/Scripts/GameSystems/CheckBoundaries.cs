using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Boundary
{
	public float minX, maxX, minZ, maxZ;
}


public class CheckBoundaries : MonoBehaviour {

	[SerializeField] private Boundary boundary;

	void Update(){
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		rigidbody.position = new Vector3
		(
			Mathf.Clamp(rigidbody.position.x, boundary.minX, boundary.maxX),
			0.0f,
			Mathf.Clamp(rigidbody.position.z, boundary.minZ, boundary.maxZ)
		);
	}
}
