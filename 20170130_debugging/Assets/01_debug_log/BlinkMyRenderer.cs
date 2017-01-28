using UnityEngine;
using System.Collections;

public class BlinkMyRenderer : MonoBehaviour
{
	public float Interval = 1.0f;

	void Update ()
	{
		bool onoff = (Time.time % Interval) < (Interval / 2);

		gameObject.GetComponent<Renderer> ().enabled = onoff;
	}
}
