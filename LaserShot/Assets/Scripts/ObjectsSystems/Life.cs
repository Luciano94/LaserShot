using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life : MonoBehaviour {
	[SerializeField] private float amount;
	[SerializeField] private int score;
	[SerializeField] private GameObject explosion;
	[SerializeField] private GameObject damage;
	[SerializeField] private GameObject pwUp;
	private float pwUpRandom;

	public float Amount
	{
		get { return amount; }
		set
		{
			amount = value;
			if (amount <= 0)
			{
				amount = 0;
				Destroy(gameObject);
				ScoreController.Instance.Score += score;
				pwUpRandom = Random.Range(1,100);
				if (pwUpRandom < 10 && gameObject.transform.position.z < 9)
					Instantiate(pwUp, gameObject.transform.position, gameObject.transform.rotation);
				Instantiate(explosion, gameObject.transform.position, gameObject.transform.rotation);
			}
			else Instantiate(damage, gameObject.transform.position, gameObject.transform.rotation);
		}
	}
}
