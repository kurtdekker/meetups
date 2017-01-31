﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class TimedSpawner : MonoBehaviour
{
	public Text OutputText;

	float spawnYet;

	public float SpawnInterval = 5.0f;

	public GameObject WhatToSpawn;

	void DoTheSpawn()
	{
		Vector3 whereToSpawn = transform.position + Random.insideUnitSphere;

		GameObject thing = Instantiate<GameObject> (WhatToSpawn);
		thing.transform.position = whereToSpawn;
	}

	void Start()
	{

// attach a QuickLabel telling how often we spawn
#if false
		QuickLabel.Create ( gameObject,
		                   "TimedSpawner:" + name + ":",
		                   () => {
			return spawnYet.ToString ( "0.0") + "s"; });
#endif
	}

	void Update ()
	{

		OutputText.text = spawnYet.ToString ( "0.0") + "s";

		spawnYet += Time.deltaTime;
		if (spawnYet >= SpawnInterval)
		{
			spawnYet = 0.0f;

			DoTheSpawn();
		}
	}

// Use the MonoBehaviour's intrinsic OnGUI() functionality
#if false
	void OnGUI()
	{
		float remaining = SpawnInterval - spawnYet;
		GUI.Label (new Rect (10, 0, 200, 50),
		           System.String.Format ("{0:0.0}s", remaining));
	}
#endif
}
