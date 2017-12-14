using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadSceneOnClick : MonoBehaviour {

	public GameObject helper;

	public void LoadByIndex(int sceneIndex) {
		SceneManager.LoadScene (sceneIndex);
	}

	public void PlaySound() {
		GetComponent<AudioSource> ().Play();
	}

	void OnMouseUpAsButton() {
		if (helper)
			helper.SetActive (false);
		SceneManager.LoadScene (0);
		XMLManager.ins.SavePlayers ();
	}
}
