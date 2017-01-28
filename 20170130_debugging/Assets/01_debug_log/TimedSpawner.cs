using UnityEngine;
using System.Collections;

public class TimedSpawner : MonoBehaviour
{
	float spawnYet;

	public float SpawnInterval = 5.0f;

	public GameObject WhatToSpawn;

	void DoTheSpawn()
	{
		Vector3 whereToSpawn = transform.position + Random.insideUnitSphere;

		GameObject thing = Instantiate<GameObject> (WhatToSpawn);
		thing.transform.position = whereToSpawn;
	}

	void Update ()
	{
		spawnYet += Time.deltaTime;
		if (spawnYet >= SpawnInterval)
		{
			spawnYet = 0.0f;

			DoTheSpawn();
		}
	}

	void OnGUI()
	{
		float remaining = SpawnInterval - spawnYet;
		GUI.Label (new Rect (10, 0, 200, 50),
		           System.String.Format ("{0:0.0}s", remaining));
	}
}
