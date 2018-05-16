using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LifeP : MonoBehaviour {
	[SerializeField] private float amount;
	[SerializeField] private GameObject explsion;
	[SerializeField] private GameObject damage;

	public float Amount
	{
		get { return amount; }
		set
		{
			amount = value;
			if (amount <= 0)
			{
				amount = 0;
				gameObject.SetActive(false);
				Instantiate(explsion, gameObject.transform.position, gameObject.transform.rotation);
			}
			else Instantiate(damage, gameObject.transform.position, gameObject.transform.rotation);
		}
	}

	void Awake()
	{
		Amount = amount;
	}
}
