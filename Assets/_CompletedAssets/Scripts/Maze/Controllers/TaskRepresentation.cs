using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TaskRepresentation : MonoBehaviour {

	// Use this for initialization
	void Start () {
		if (PlayerPrefs.GetInt ("CompletedTasks", 0) != null) {
			int completedTasks = PlayerPrefs.GetInt ("CompletedTasks", 0);
			PlayerPrefs.SetInt("CompletedTasks", completedTasks+1);
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void GoBackToLabyrinth() {
		SceneManager.LoadScene ("Maze");
	}
}
