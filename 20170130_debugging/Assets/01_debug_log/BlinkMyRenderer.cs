using UnityEngine;
using System.Collections;

public class BlinkMyRenderer : MonoBehaviour
{
	void Update ()
	{
		bool onoff = (Time.time % 1.0f) < 0.5f;

		gameObject.GetComponent<Renderer> ().enabled = onoff;
	}
}
