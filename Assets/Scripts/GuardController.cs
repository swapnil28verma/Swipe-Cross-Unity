﻿using UnityEngine;
using System.Collections;

public class GuardController : MonoBehaviour {

	public Transform[] points;
	private int destPoint = 0;
	private UnityEngine.AI.NavMeshAgent agent;

	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

		// Disabling auto-braking allows for continuous movement
		// between points (ie, the agent doesn't slow down as it
		// approaches a destination point).
		agent.autoBraking = false;

		GotoNextPoint();
	}


	void GotoNextPoint() {
		// Returns if no points have been set up
//		agent.transform.Rotate (new Vector3 (0, 90, 0));
		if (points.Length == 0)
			return;

		// Set the agent to go to the currently selected destination.


		// Choose the next point in the array as the destination,
		// cycling to the start if necessary.
		destPoint = (destPoint + 1) % points.Length;
	}


	void Update () {
		// Choose the next destination point when the agent gets
		// close to the current one.
		if (agent.remainingDistance < 0.05f)
			GotoNextPoint();

		agent.destination = points[destPoint].position;
	}
}
