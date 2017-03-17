using UnityEngine;
using System.Collections;

public class CameraController : MonoBehaviour {

	private Vector3 from;
	private Vector3 to;
	public float speed = 1.0f; 
	public float angle = 0;
	public bool singleRotate;

	void Start() {
		from = new Vector3(0, this.transform.parent.rotation.eulerAngles.y - angle, 0);
		to = new Vector3(0, this.transform.parent.rotation.eulerAngles.y + angle, 0);
	}

	void Update() {
		if (singleRotate) {
//			transform.Rotate(new Vector3(0, transform.rotation.eulerAngles.y + 1, 0));
			transform.Rotate(0, Time.deltaTime * speed * 100, 0);
		}
		else {
			float t = Mathf.PingPong(Time.time * speed * 2.0f, 1.0f);
			transform.eulerAngles = Vector3.Lerp (from, to, t);
		}
	}
}
