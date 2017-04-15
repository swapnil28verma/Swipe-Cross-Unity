using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour {

	public GameObject Gate, Gate2;
	public Transform open1, open2;
	public bool isGateClosed = true;
	private Vector3 closedPosition1, closedPosition2;
	public float smoothing = 4f;

	void Start() {

		closedPosition1 = Gate.transform.position;
		closedPosition2 = Gate2.transform.position;
	}

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			if (isGateClosed) {
				StopCoroutine ("gateCloseCoroutine");
				StartCoroutine ("gateOpenCoroutine");
			} else {
				StopCoroutine ("gateOpenCoroutine");
				StartCoroutine ("gateCloseCoroutine");
			}				
		}
	}

	IEnumerator gateOpenCoroutine() {

		float elapsedTime = 0;
		while (Vector3.Distance (Gate.transform.position, open1.position) > 0.05f) {
			isGateClosed = false;
			Gate.transform.position = Vector3.Lerp (closedPosition1, open1.position,  smoothing * elapsedTime);
			Gate2.transform.position = Vector3.Lerp (closedPosition2, open2.position, smoothing * elapsedTime);

			elapsedTime += Time.deltaTime;

			yield return null;
		}
		Debug.Log ("Gate Opened");

		yield return null;
	}
	IEnumerator gateCloseCoroutine() {
		float elapsedTime = 0;
		while (Vector3.Distance(Gate.transform.position, closedPosition1) >0.05f) {
			isGateClosed = true;
			Gate.transform.position = Vector3.Lerp (open1.position, closedPosition1, smoothing * elapsedTime);
			Gate2.transform.position = Vector3.Lerp (open2.position, closedPosition2, smoothing * elapsedTime);

			elapsedTime += Time.deltaTime;

			yield return null;
		}
		Debug.Log ("Gate Closed");

		yield return null;
	}
}