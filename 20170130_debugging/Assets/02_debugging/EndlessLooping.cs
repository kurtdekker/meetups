using UnityEngine;
using System.Collections;

public class EndlessLooping : MonoBehaviour
{
	void Start ()
	{
		// Just to show we are "alive" and running
		QuickLabel.Create ( gameObject,
		                   "Time: ", () =>
		{
			return Time.time.ToString ("0.0"); });
	}

	public void BeginMyEndlessIntegerLoop()
	{
		int j = 0;
		
		for (int i = 0; i != 100; )
		{
			j += i;
		}
	}

	public void BeginMyEndlessSearchLoop()
	{
		int i = 123;
		bool done = false;
		while (!done)
		{
			int j = Random.Range ( 0, 100);
			if (j == i)
			{
				done = true;
			}
		}
	}
}
