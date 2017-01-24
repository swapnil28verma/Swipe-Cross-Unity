using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed;
	private Rigidbody player;
	float horizontalMove;
	float verticalMove;

	Vector2 beginPoint, endPoint;

	Vector3 force;

	void Start() {
		player = GetComponent<Rigidbody>();
	}

	void FixedUpdate () {

		//Touch input
		if(Input.touchCount>0) {
			Touch touchEvent = Input.touches[0];
			if(touchEvent.phase == TouchPhase.Began) {
				beginPoint = touchEvent.position;
			}
			else if(touchEvent.phase == TouchPhase.Ended) {
				endPoint = touchEvent.position;
			}

			horizontalMove = endPoint.x - beginPoint.x;
			verticalMove = endPoint.y - beginPoint.y;
		}
		else {					//Keyboard input
			horizontalMove = Input.GetAxis("Horizontal");
			verticalMove = Input.GetAxis("Vertical");
		}
			
		force = new Vector3(horizontalMove, 0, verticalMove);
		player.AddForce(force * speed);
	}
}
