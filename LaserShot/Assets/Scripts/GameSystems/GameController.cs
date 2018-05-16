using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class GameController : MonoBehaviour {
	private static GameController instance;

	public static GameController Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<GameController>();
				if (instance == null) //Si no encontre el instance
				{
					GameObject go = new GameObject("GameController");
					instance = go.AddComponent<GameController>();
				}
			}

			return instance;
		}
	}

	[SerializeField] private GameObject player;
	[SerializeField] private GameObject boss;
	private float timeLeft = 120.0f;
	private bool bossFigth;

	public float PlayerLives
	{
		get { if (player) return player.GetComponent<LifeP>().Amount;
			else return 3;
		}
	}
	public GameObject Player
	{
		get { return player; }
		set { player = value; }
	}
	public GameObject Boss
	{
		set { boss = value; }
	}
	public float BossLife
	{
		get { if (boss) return boss.GetComponent<Life>().Amount;
			else return 100;
		}
	}
	public bool BossFigth
	{
		get { return bossFigth; }
	}
	public float TimeLeft
	{
		get { return timeLeft; }
	}

	void Awake()
	{
		bossFigth = false;
	}

	void Update()
	{
		/*Boss Figth*/
		timeLeft -= Time.deltaTime;
		if (timeLeft < 0 && boss)
		{
			bossFigth = true;
			boss.SetActive(true);
		}
		if (!boss)
		{
			Invoke("WinScene", 2);
		}
		/*LoseManager*/
		if (player && !player.activeSelf)
			Invoke("LooseScene", 2);
	}

	void WinScene()
	{
		bossFigth = false;
		if (SceneManager.GetActiveScene().name != "WinScene"){
			SceneManager.LoadScene("WinScene");
		}
		else CancelInvoke();
	}

	void LooseScene() {
		if (SceneManager.GetActiveScene().name != "LoseScene") {
			SceneManager.LoadScene("LoseScene");
		}
		else CancelInvoke();
	}
}
