using UnityEngine;
using System.Collections;

public class BallisticObject : MonoBehaviour
{
	// Set this in the inspector
	public Vector3 initialVelocity;

	// This is the "working" value of the velocity over time
	public Vector3 velocity;

	void Awake()
	{
		velocity = initialVelocity;
	}

	// This does the simulation step, and you can call it externally.
	// TrajectoryVisualizer calls it externally to generate the trajectory.
	public void MoveAmountOfTime ( float t)
	{
		velocity += Physics.gravity * t;

		transform.position += velocity * t;
	}

	void Update()
	{
		MoveAmountOfTime( Time.deltaTime);
	}
}
