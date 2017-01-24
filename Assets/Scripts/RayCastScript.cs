using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RayCastScript : MonoBehaviour {

	LineRenderer laserProjector;
	RaycastHit hit;
	Vector3 forward;
	public float distance;

	void Start() {
		laserProjector = GetComponent<LineRenderer> ();
	}

	void Update () {
		forward = transform.TransformDirection(Vector3.forward) * distance;
		Debug.DrawRay(transform.position, forward, Color.red);

		if (Physics.Raycast (transform.position, forward, out hit)) {

			if (hit.transform.gameObject.tag == "Player") {
				Debug.Log ("Player Detected by Laser");
				SceneManager.LoadScene ("GameLose");

			} 
			if (hit.transform.gameObject.tag == "Enemy Guard") {
				laserProjector.SetPosition (0, transform.position);
				laserProjector.SetPosition (1, transform.position);
			} else {
				laserProjector.SetPosition (0, transform.position);
				laserProjector.SetPosition (1, hit.point);
			}
		}
	}
}
