using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ViewMovementController : MonoBehaviour {

	public Transform creditsTransform, playTransform, quitTransform, mainmenuTranform;
	public float smoothing = 0.3f;

	public void moveToCreditTransform() {
		StopCoroutine ("moveCamera");
		StartCoroutine ("moveCamera", creditsTransform);
	}

	public void moveToMainMenuTransform() {
		StopCoroutine ("moveCamera");
		StartCoroutine ("moveCamera", mainmenuTranform);
	}

	public void moveToQuitTransform() {
		StopCoroutine ("moveCamera");
		StartCoroutine ("moveCamera", quitTransform);
	}

	public void moveToPlayTransform() {
		StopCoroutine ("moveCamera");
		StartCoroutine ("moveCamera", playTransform);
	}

	IEnumerator moveCamera(Transform finalPosition) {
		float elapsedTime = 0;

		while (Vector3.Distance (gameObject.transform.position, finalPosition.position) > 0.05f) {
			gameObject.transform.position = Vector3.Lerp (gameObject.transform.position, finalPosition.position, smoothing * elapsedTime);
			gameObject.transform.rotation = Quaternion.Lerp (gameObject.transform.rotation, finalPosition.rotation, smoothing * elapsedTime);
			elapsedTime += Time.deltaTime;

			yield return null;
		}
		yield return null;
	}
}
