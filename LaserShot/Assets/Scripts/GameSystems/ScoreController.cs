using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;


public class ScoreController : MonoBehaviour {

	private static ScoreController instance;

	public static ScoreController Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<ScoreController>();
				if (instance == null) //Si no encontre el instance
				{
					GameObject go = new GameObject("ScoreController");
					go.AddComponent<DontDestroyOnLoad>();
					instance = go.AddComponent<ScoreController>();
				}
			}

			return instance;
		}
	}

	[SerializeField] private int score;

	public int Score{
		get { return score; }
		set { score = value; }
	}

	void Awake(){
		score = 0;
	}
}
