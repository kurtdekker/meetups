using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// put this on the camera to track the player (keep the player centered)

public class FollowPlayer : MonoBehaviour
{
	GameObject player;

	void Update ()
	{
		if (!player)
		{
			player = GameObject.Find( "Player");
		}

		if (player)
		{
			Vector3 pos = transform.position;

			pos.x = player.transform.position.x;
			pos.y = player.transform.position.y;
				
			transform.position = pos;
		}
	}
}
