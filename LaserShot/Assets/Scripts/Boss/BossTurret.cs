using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossTurret : MonoBehaviour {
	[SerializeField] private float rotationSpeed;
	private bool cambie = false;

	void Update () {
		if (GameController.Instance.BossLife < 80)
			rotationSpeed = 3;
		if (GameController.Instance.BossLife < 50)
			rotationSpeed = 4;
		if (transform.rotation.y >= 0.03) cambie = true;
		if (transform.rotation.y <= -0.03) cambie = false;
		if (!cambie)
			transform.Rotate(0, rotationSpeed * Time.deltaTime, 0);
		if (cambie)
			transform.Rotate(0, -rotationSpeed * Time.deltaTime, 0);
	}
}
