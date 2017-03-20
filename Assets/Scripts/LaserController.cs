using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserController : MonoBehaviour {

	public GameObject attachedLaserRaycast;

	void OnTriggerEnter(Collider other) {
		if (other.gameObject.tag == "Player") {
			attachedLaserRaycast.SetActive (!attachedLaserRaycast.activeSelf);
			Debug.Log ("Button Pressed");
		}
	}

}
