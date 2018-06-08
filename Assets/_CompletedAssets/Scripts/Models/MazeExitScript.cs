using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MazeExitScript : MonoBehaviour {

	private double timer = 2.0;
	
	// Update is called once per frame
	void Update () {
		timer -= Time.deltaTime;
		if (timer <= 0) {
			SceneManager.LoadScene ("Forest");
		}
	}
}
