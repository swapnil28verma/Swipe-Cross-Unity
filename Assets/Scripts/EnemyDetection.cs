using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class EnemyDetection : MonoBehaviour {


	public GameObject player;
	private Camera cam;
	private Plane[] planes;

	// Use this for initialization
	void Start () {
		cam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update () {
		planes = GeometryUtility.CalculateFrustumPlanes(cam);

		if(GeometryUtility.TestPlanesAABB(planes, player.GetComponent<SphereCollider>().bounds)) {
			Debug.Log("Player Detected by " + gameObject.name);
			SceneManager.LoadScene ("GameLose");
		}
	}
}
