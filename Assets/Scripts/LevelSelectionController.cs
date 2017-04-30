using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LevelSelectionController : MonoBehaviour {

	public Button World1;
	public Button World2;
	public Button World3;
	public Button World4;
	public Button World5;
	public GameObject world1Container;
	public GameObject world2Container;
	public GameObject world3Container;
	public GameObject world4Container;
	public GameObject world5Container;
	public RectTransform originalScrollerPosition;
	public GameObject scroller;

	public void Start() {
		scroller.GetComponent<RectTransform> ().localPosition = originalScrollerPosition.localPosition;
		world1Container.SetActive (true);
		world2Container.SetActive (false);
		world3Container.SetActive (false);
		world4Container.SetActive (false);
		world5Container.SetActive (false);
	}

	public void world1Press() {
		scroller.GetComponent<RectTransform> ().position = originalScrollerPosition.position;

		world1Container.SetActive (true);
		world2Container.SetActive (false);
		world3Container.SetActive (false);
		world4Container.SetActive (false);
		world5Container.SetActive (false);
	}

	public void world2Press() {
//		scroller.GetComponent<RectTransform> ().localPosition = originalScrollerPosition;

		world1Container.SetActive (false);
		world2Container.SetActive (true);
		world3Container.SetActive (false);
		world4Container.SetActive (false);
		world5Container.SetActive (false);
	}

	public void world3Press() {
//		scroller.GetComponent<RectTransform> ().localPosition = originalScrollerPosition;

		world1Container.SetActive (false);
		world2Container.SetActive (false);
		world3Container.SetActive (true);
		world4Container.SetActive (false);
		world5Container.SetActive (false);
	}

	public void world4Press() {
//		scroller.GetComponent<RectTransform> ().localPosition = originalScrollerPosition;

		world1Container.SetActive (false);
		world2Container.SetActive (false);
		world3Container.SetActive (false);
		world4Container.SetActive (true);
		world5Container.SetActive (false);
	}

	public void world5Press() {
//		scroller.GetComponent<RectTransform> ().localPosition = originalScrollerPosition;

		world1Container.SetActive (false);
		world2Container.SetActive (false);
		world3Container.SetActive (false);
		world4Container.SetActive (false);
		world5Container.SetActive (true);
	}


}
