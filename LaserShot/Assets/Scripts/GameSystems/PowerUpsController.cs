using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpsController : MonoBehaviour {
	private static PowerUpsController instance;

	public static PowerUpsController Instance
	{
		get
		{
			if (instance == null)
			{
				instance = FindObjectOfType<PowerUpsController>();
				if (instance == null) //Si no encontre el instance
				{
					GameObject go = new GameObject("PowerUpsController");
					instance = go.AddComponent<PowerUpsController>();
				}
			}

			return instance;
		}
	}
	[SerializeField] private GameObject turretIzq;
	[SerializeField] private GameObject turretDer;
	[SerializeField] private GameObject player;

	public GameObject TurrentIzq
	{
		get { return turretIzq; }
	}
	public GameObject TurrentDer
	{
		get { return turretDer; }
	}

	void Awake()
	{
		turretIzq.SetActive(false);
		turretDer.SetActive(false);
	}
}
