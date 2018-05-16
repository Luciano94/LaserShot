using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipMover : MonoBehaviour {

	[SerializeField] private float speed;

	void Update(){
		float movX = speed * Time.deltaTime;

		if (GameController.Instance.Player.transform.position.x > transform.position.x)
			transform.Translate(movX, 0, 0);
		if (GameController.Instance.Player.transform.position.x < transform.position.x)
			transform.Translate(-movX, 0, 0);
	}
}
