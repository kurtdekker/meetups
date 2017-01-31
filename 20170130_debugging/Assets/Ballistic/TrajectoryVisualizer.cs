using UnityEngine;
using System.Collections;

public class TrajectoryVisualizer : MonoBehaviour
{
	public BallisticObject originalBo;

	public float TimeToSimulate = 3.0f;

	void Start ()
	{
		// We have the original ball in the scene
		// We make a dupe of it so we can move it while leaving the original alone
		GameObject dupe = Instantiate<GameObject>( originalBo.gameObject);
		dupe.transform.position = originalBo.transform.position;

		// Now we get the BO attached to the duplicate
		BallisticObject dupeBo = dupe.GetComponent<BallisticObject>();
		dupeBo.velocity = originalBo.velocity;

		// how fine an interval do we want to simulate? (finer the better!)
		float interval = 1 / 60.0f;

		// how many points would that produce?
		int numPoints = (int)(TimeToSimulate / interval);

		// we have a LR on us already
		LineRenderer LR = gameObject.GetComponent<LineRenderer>();

		// width
		LR.SetWidth ( 0.1f, 0.1f);

		// now we "drive" the dupe BO along the path of its trajectory
		// by telling it that the time is advancing by "interval" repeatedly.
		// After each time, we record where it is.
		LR.SetVertexCount( numPoints);
		for (int i = 0; i < numPoints; i++)
		{
			// record where the dupe ball is
			LR.SetPosition ( i, dupe.transform.position);

			// tell the dupe ball to move
			dupeBo.MoveAmountOfTime ( interval);
		}

		// we're done with the dupe ball, destroy it
		Destroy( dupe);

		// we are done making the line render, so we can destroy ourselves
		// (leaving behind the gameObject and LineRender)
		Destroy ( this);
	}
}
