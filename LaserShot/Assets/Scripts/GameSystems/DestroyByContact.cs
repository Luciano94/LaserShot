using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByContact : MonoBehaviour {
	[SerializeField] private GameObject explosion;
	[SerializeField] private GameObject playerExplosion;
	[SerializeField] private int score;

	void OnTriggerEnter(Collider other){
		if(other.tag != "Boundaries"){
			Instantiate(explosion, transform.position, transform.rotation);
			ScoreController.Instance.Score += score;
			if (other.tag == "Player"){
				Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
				ScoreController.Instance.Score = 0;

			}
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
