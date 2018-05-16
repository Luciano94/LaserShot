using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShoot : MonoBehaviour {
	[SerializeField] private GameObject shot;
	[SerializeField] private float fireRate;

	private float nextFire;

	void Update() {
		if (Input.GetButton("Fire1") && Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate(shot, transform.position, transform.rotation);
		}
	}
}
