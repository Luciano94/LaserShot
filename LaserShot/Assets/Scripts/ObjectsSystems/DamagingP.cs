using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamagingP : MonoBehaviour {
	[SerializeField] float damage;

	void OnTriggerEnter(Collider other)
	{
		Life life = other.GetComponent<Life>();
		if (life){
			life.Amount -= damage;
			if (gameObject.tag != "Player")
				Destroy(gameObject);
		}
	}
}
