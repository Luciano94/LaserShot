﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour {
	[SerializeField] private GameObject playerExplosion;

	void OnTriggerEnter(Collider other){
		if(other.tag != "Boundaries"){
			Instantiate(playerExplosion, other.transform.position, other.transform.rotation);
			Destroy(other.gameObject);
			Destroy(gameObject);
		}
	}
}
