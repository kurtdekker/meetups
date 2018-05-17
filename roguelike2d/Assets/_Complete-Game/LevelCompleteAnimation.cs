using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelCompleteAnimation : MonoBehaviour
{
	public static void Attach( GameObject player)
	{
		LevelCompleteAnimation lca =
			new GameObject( "LevelCompleteAnimation").AddComponent<LevelCompleteAnimation>();

		// goto where the player is now
		lca.transform.position = player.transform.position;

		// now parent the player to us so we can spin him around
		player.transform.SetParent( lca.transform);
	}

	// all animations are this length
	float duration = 1.0f;

	IEnumerator ShrinkDownAndVanish()
	{
		for (float t = 0; t < duration; t += Time.deltaTime)
		{
			// shrink him down
			float scale = (duration - t) / duration;
			transform.localScale = Vector3.one * scale;

			yield return null;
		}
	}

	IEnumerator SpinAroundYAxis()
	{
		for (float t = 0; t < duration; t += Time.deltaTime)
		{
			// flip him around the Y axis a few times
			float angle = (t * 360 * 2) / duration;
			transform.rotation = Quaternion.Euler( 0, angle, 0);

			yield return null;
		}
	}

	// cycle through available exit animations
	static int counter;

	void Start()
	{
		counter++;

		switch( counter % 2)
		{
		default :
		case 0 :
			StartCoroutine( ShrinkDownAndVanish());
			break;
		case 1 :
			StartCoroutine( SpinAroundYAxis());
			break;
		}
	}
}
