using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class DestinationController : MonoBehaviour {

	void OnTriggerEnter(Collider other) {
		if(other.gameObject.tag == "Player") {
			Debug.Log ("Destination reached"); 
			SceneManager.LoadScene ("GameWin");
		}
	}
}
