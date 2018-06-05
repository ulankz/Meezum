using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public void LoadByIndex(int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
		//if (SceneManager.GetActiveScene().name != "Forest")
			//GameObject.Find("btn_door").SetActive(false);
	}

	public void PlaySound() {
		GetComponent<AudioSource> ().Play();
	}

	void MouseUpAsButton() {
		
		SceneManager.LoadScene (0);
		XMLManager.ins.SavePlayers ();
	}
}
