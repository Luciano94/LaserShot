﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyByTime : MonoBehaviour {
	[SerializeField] private float timelife;

	void Awake(){
		Destroy(gameObject, timelife);
	}
}