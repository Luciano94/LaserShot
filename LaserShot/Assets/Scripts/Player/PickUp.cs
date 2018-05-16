using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour {
	[SerializeField] private int score;

	void OnTriggerEnter(Collider other)
	{
		Destroy(gameObject);
		ScoreController.Instance.Score += score;
		PowerUpsController.Instance.TurrentIzq.SetActive(true);
		PowerUpsController.Instance.TurrentDer.SetActive(true);
	}
}
