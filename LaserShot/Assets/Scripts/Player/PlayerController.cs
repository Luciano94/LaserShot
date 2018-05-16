using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	[SerializeField] private float speed;
	[SerializeField] private float tilt;

	void Update(){

		float moveHorizontal = speed * Input.GetAxis("Horizontal");
		float moveVertical = speed * Input.GetAxis("Vertical");
		Rigidbody rigidbody = GetComponent<Rigidbody>();

		/*movement*/
		rigidbody.velocity = new Vector3(moveHorizontal, 0.0f, moveVertical);
		rigidbody.rotation = Quaternion.Euler(0.0f, 0.0f, rigidbody.velocity.x * -tilt);
	}
}
