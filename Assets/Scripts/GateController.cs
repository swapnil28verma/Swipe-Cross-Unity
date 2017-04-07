using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GateController : MonoBehaviour {

	public GameObject Gate, Gate2;
	public Transform open1, open2;
	private bool isGateClosed = true;
//	private Vector3 closedTransform, openTransform;
	private Vector3 closedPosition1, closedPosition2;
	public float smoothing = 1f;

	void Start() {
//		closedTransform = Gate.transform.position;
//		openTransform = Gate.transform.position;
//		openTransform.y = -1;
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

		while (Vector3.Distance (Gate.transform.position, open1.position) > 0.05f) {
			isGateClosed = false;
			Gate.transform.position = Vector3.Lerp (closedPosition1, open1.position, smoothing * Time.deltaTime);
			Gate2.transform.position = Vector3.Lerp (closedPosition2, open2.position, smoothing * Time.deltaTime);
//			yield return null;
		}
		Debug.Log ("Gate Opened");

		yield return null;
	}
	IEnumerator gateCloseCoroutine() {
		while (Vector3.Distance(Gate.transform.position, closedPosition1) >0.05f) {
			isGateClosed = true;
			Gate.transform.position = Vector3.Lerp (open1.position, closedPosition1, smoothing * Time.deltaTime);
			Gate2.transform.position = Vector3.Lerp (open2.position, closedPosition2, smoothing * Time.deltaTime);
			yield return null;
		}
		Debug.Log ("Gate Closed");

		yield return null;
	}
}
//				Gate.transform.position = Vector3.Lerp (closedTransform, openTransform, 1);
//				Gate.transform.position = Vector3.Lerp (openTransform, closedTransform, 1);