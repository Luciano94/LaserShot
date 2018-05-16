using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidsController : MonoBehaviour {
	[SerializeField] private GameObject[] hazards;
	[SerializeField] private Vector3 spawnValues;
	[SerializeField] private float waveWait;
	[SerializeField] private int astPerWave;

	void Awake(){
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
			waveWait = 0.5f;
	}

	void SpawnWaves(){
		for (int i = 0; i < astPerWave; i++)
		{
			GameObject hazard = hazards[Random.Range(0, hazards.Length)];
			Vector3 spawnPosition = new Vector3(Random.Range(-spawnValues.x, spawnValues.x), spawnValues.y, spawnValues.z);
			Quaternion spawnRotation = Quaternion.identity;
			Instantiate(hazard, spawnPosition, spawnRotation);
		}
		if (GameController.Instance.BossFigth)
			CancelInvoke();
		else
			Invoke("SpawnWaves", waveWait);
	}
}
