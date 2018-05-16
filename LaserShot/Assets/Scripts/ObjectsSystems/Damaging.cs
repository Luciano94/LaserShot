using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damaging : MonoBehaviour{
	[SerializeField] float damage;

	void OnTriggerEnter(Collider other)
	{
		LifeP life = other.GetComponent<LifeP>();
		if (life){
			life.Amount -= damage;
			Destroy(gameObject);
		}
	}
}
