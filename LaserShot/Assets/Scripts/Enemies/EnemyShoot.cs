using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShoot : MonoBehaviour {

	[SerializeField] private GameObject shot;
	[SerializeField] private float fireRate;

	public float FireRate
	{
		get { return fireRate; }
		set { fireRate = value;}
	}

	private float nextFire;

	void Update(){
		if (Time.time > nextFire){
			nextFire = Time.time + fireRate;
			Instantiate(shot, transform.position, transform.rotation);
		}
	}
}
