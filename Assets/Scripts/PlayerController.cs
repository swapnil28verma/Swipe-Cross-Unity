using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed, maxForce;
	private Rigidbody player;
	Vector3 movement;

	Vector3 beginPoint, endPoint;
	Vector3 dir = new Vector3(0, 0, 0);

	Vector3 force;

	void Start() {
		player = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {
		//Fix rotation to the direction of movement
		transform.LookAt(transform.position + player.velocity - dir);

		if (Input.GetMouseButtonDown (0)) {

			player.velocity = Vector3.zero;
			player.angularVelocity = Vector3.zero;

			beginPoint = Input.mousePosition;
			beginPoint.z = beginPoint.y;
			beginPoint.y = 0;

			endPoint = beginPoint;

		} else if (Input.GetMouseButtonUp (0)) {

			endPoint = Input.mousePosition;
			endPoint.z = endPoint.y;
			endPoint.y = 0;

			movement.x = endPoint.x - beginPoint.x;
			movement.z = endPoint.z - beginPoint.z;

			beginPoint = Vector3.zero;
			endPoint = Vector3.zero;

		}
//		movement = endPoint - beginPoint;
		Debug.Log (beginPoint + " begin Point");
		Debug.Log (endPoint + " end Point");
		Debug.Log (movement + " movement");
		force = movement * speed;

		if (force.x > maxForce) {
			force.x = maxForce;
		}
		if (force.z > maxForce) {
			force.z = maxForce;
		}
		player.AddForce (force);
		movement = Vector3.zero;


	}
}
