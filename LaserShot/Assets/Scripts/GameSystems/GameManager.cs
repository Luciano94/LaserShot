using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GameManager : MonoBehaviour {
	[SerializeField] private GameObject player;
	[SerializeField] private GameObject boss;
	 private GameController gameController;
	 private ScoreController scoreController;

	void Awake()
	{
		gameController = GameController.Instance;
		scoreController = ScoreController.Instance;
		/*gameController*/
		gameController.Player = player;
		gameController.Boss = boss;
		/*ScoreController*/
		scoreController.Score = 0;
	}
}
