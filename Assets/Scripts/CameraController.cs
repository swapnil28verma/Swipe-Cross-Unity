using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3 from;
	private Vector3 to;
	public float speed = 1.0f; 
	public float angle = 0;

	void Start() {
		from = new Vector3(0, -angle, 0);
		to = new Vector3(0, angle, 0);
	}

	void Update() {
		float t = Mathf.PingPong(Time.time * speed * 2.0f, 1.0f);
		transform.eulerAngles = Vector3.Lerp (from, to, t);
	}
}
