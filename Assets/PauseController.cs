using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseController : MonoBehaviour {

	public Canvas pauseMenu;

	public Button resume;
	public Button restart;
	public Button quit;

	public Image pause;

	public Sprite volSprite, volMuteSprite;

	public Toggle volume;

	private bool isMute = false;

	public void Start() {
		pauseMenu.enabled = false;

	}

	public void pausePress() {
		Time.timeScale = 0f;
		pause.enabled = false;
		pauseMenu.enabled = true;
		Debug.Log ("Pause pressed");
	}

	public void resumePress() {
		Time.timeScale = 1f;
		pause.enabled = true;
		pauseMenu.enabled = false;

	}

	public void volumePress() {

		if (isMute) {

			volume.GetComponent<Image> ().sprite = volSprite;
		} else {
			volume.GetComponent<Image> ().sprite = volMuteSprite;
		}
		isMute = !isMute;

	}

	public void restartPress() {

		SceneManager.LoadScene (SceneManager.GetActiveScene().name);
	}

	public void quitPress() {

		SceneManager.LoadScene ("MainMenu");
	}


}
