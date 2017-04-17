using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour {

	public Canvas quitMenu;
	public Canvas creditMenu;
	public Canvas mainMenu;
	public Button playButton;
	public Button exitButton;
	public Button volButton;
	public Button shareButton;
	public Button creditsButton;
	public Camera mainCamera;


	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;

		creditMenu = creditMenu.GetComponent<Canvas> ();
		creditMenu.enabled = false;

		mainMenu = mainMenu.GetComponent<Canvas> ();

		mainCamera = mainCamera.GetComponent<Camera> ();

		playButton = playButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
		volButton = volButton.GetComponent<Button> ();
		shareButton = shareButton.GetComponent<Button> ();
		creditsButton = creditsButton.GetComponent<Button> ();
		
	}
	
	public void QuitPress() {
		mainCamera.GetComponent<ViewMovementController> ().moveToQuitTransform ();

		quitMenu.enabled = true;
		mainMenu.enabled = false;
	}

	public void QuitConfirm() {
		Application.Quit ();
	}
		
	public void NoPress() {
		mainCamera.GetComponent<ViewMovementController> ().moveToMainMenuTransform ();

		quitMenu.enabled = false;
		mainMenu.enabled = true;
	}

	public void PlayPress() {
		SceneManager.LoadScene ("move_test"); 
	}

	public void CreditsPress() {
		mainCamera.GetComponent<ViewMovementController> ().moveToCreditTransform ();

		creditMenu.enabled = true;
		mainMenu.enabled = false;
	}

	public void BackPress(Canvas current) {
		mainCamera.GetComponent<ViewMovementController> ().moveToMainMenuTransform ();

		current.enabled = false;
		mainMenu.enabled = true;
	}
}
