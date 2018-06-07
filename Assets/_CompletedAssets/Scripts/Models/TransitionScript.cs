using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TransitionScript : MonoBehaviour {
	public void moveToScene() {
		string sceneName = SceneManager.GetActiveScene ().name;
		switch (sceneName) {
			case "Forest":
				SceneManager.LoadScene ("Comics");
				break;
			case "Comics":
				SceneManager.LoadScene ("Maze");
				break;
		}
	}

	public void quitFromScene() {
		string sceneName = SceneManager.GetActiveScene ().name;
		switch (sceneName) {
			case "Comics":
			case "Maze":
				SceneManager.LoadScene ("Forest");
				break;
		case "QuizGame":
		case "GameOfWords":
		case "Classification":
			SceneManager.LoadScene ("Maze");
			break;

		}
	}
}
