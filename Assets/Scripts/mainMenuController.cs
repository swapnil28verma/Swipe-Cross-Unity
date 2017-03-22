using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class mainMenuController : MonoBehaviour {

	public Canvas quitMenu;
	public Button playButton;
	public Button exitButton;
	public Button volButton;
	public Button shareButton;



	// Use this for initialization
	void Start () {

		quitMenu = quitMenu.GetComponent<Canvas> ();
		quitMenu.enabled = false;

		playButton = playButton.GetComponent<Button> ();
		exitButton = exitButton.GetComponent<Button> ();
		volButton = volButton.GetComponent<Button> ();
		shareButton = shareButton.GetComponent<Button> ();
		
	}
	
	public void QuitPress() {
		quitMenu.enabled = true;

		playButton.enabled = false;
		exitButton.enabled = false;
		volButton.enabled = false;
		shareButton.enabled = false;
	}

	public void QuitConfirm() {
		Application.Quit ();
	}

	public void NoPress() {
		
		quitMenu.enabled = false;

		playButton.enabled = true;
		exitButton.enabled = true;
		volButton.enabled = true;
		shareButton.enabled = true;
	}

	public void PlayPress() {
		SceneManager.LoadScene ("First"); 
	}
}
