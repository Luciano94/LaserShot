using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyShipController : MonoBehaviour {
	[SerializeField] private GameObject enemy;
	[SerializeField] private Vector3 spawnValues;
	[SerializeField] private float waveWait;

	void Awake()
	{
		if (!GameController.Instance.BossFigth)
			Invoke("SpawnWaves", waveWait);
	}
	void Update()
	{
		if (GameController.Instance.TimeLeft < 90)
			waveWait = 4;
		if (GameController.Instance.TimeLeft < 60)
			waveWait = 3;
		if (GameController.Instance.TimeLeft < 40)
			waveWait = 2.5f;
		if (GameController.Instance.TimeLeft < 25)
			waveWait = 1.5f;
		if (GameController.Instance.TimeLeft < 15)
			waveWait = 1;
		if (GameController.Instance.TimeLeft < 10)
			waveWait = 0.7f;
	}

	void SpawnWaves()
	{
		Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
		Quaternion spawnRotation = Quaternion.identity;
		Instantiate(enemy, spawnPosition, spawnRotation);
		if (GameController.Instance.BossFigth)
			CancelInvoke();
		else
			Invoke("SpawnWaves", waveWait);
	}
}
