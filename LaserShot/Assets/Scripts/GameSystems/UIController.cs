using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine;

public class UIController : MonoBehaviour {

	[SerializeField]private Slider bossHeal;
	[SerializeField]private Text lives;
	[SerializeField]private Text score;
	[SerializeField] private Text time;

	void Update(){
		if(SceneManager.GetActiveScene().name == "LoseScene"){
			bossHeal.gameObject.SetActive(false);
			time.gameObject.SetActive(false);
			lives.gameObject.SetActive(false);
			score.gameObject.SetActive(true);
			score.text = "Score: " + ScoreController.Instance.Score.ToString();
		}
		if (SceneManager.GetActiveScene().name == "WinScene")
		{
			time.gameObject.SetActive(false);
			bossHeal.gameObject.SetActive(false);
			lives.gameObject.SetActive(false);
			score.gameObject.SetActive(true);
			score.text = "Score: " + ScoreController.Instance.Score.ToString();
		}
		if (SceneManager.GetActiveScene().name == "Main")
		{

			time.text = "Time: " + Mathf.Round(GameController.Instance.TimeLeft).ToString();
			score.text = "Score: " + ScoreController.Instance.Score.ToString();
			lives.text = "Health: " + GameController.Instance.PlayerLives.ToString();
			if (GameController.Instance.BossFigth)
			{
				time.gameObject.SetActive(false);
				bossHeal.gameObject.SetActive(true);
				bossHeal.value = GameController.Instance.BossLife;
			}
			else{
				bossHeal.gameObject.SetActive(false);
				lives.gameObject.SetActive(true);
				score.gameObject.SetActive(true);
				time.gameObject.SetActive(true);
			}
		}
	}
}
