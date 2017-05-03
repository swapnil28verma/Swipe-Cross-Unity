using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class LevelLoader : MonoBehaviour {

	public void loadLevel() {

		SceneManager.LoadScene (EventSystem.current.currentSelectedGameObject.name);
	}
}
