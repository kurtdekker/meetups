using UnityEngine;
using System.Collections;

public class YKillPlane : MonoBehaviour
{
	public float YKillValue = -10.0f;

	void Update ()
	{
		if (transform.position.y < YKillValue)
		{
			Destroy (gameObject);
			return;
		}
	}
}
