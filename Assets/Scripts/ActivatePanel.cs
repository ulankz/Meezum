using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using MeezumGame;
public class ActivatePanel : MonoBehaviour {
	
	public GameObject panel;
	public GameObject helper;
	//public GameObject[] colliderHolders;
	private InteractiveSpriteTracker movableGO;

	Button optionsButton;
	void Start() {
		movableGO = GameObject.FindGameObjectWithTag (Tags.MOVABLE_OBJECT).GetComponent<InteractiveSpriteTracker> ();
		//colliderHolders = GameObject.FindGameObjectsWithTag (Tags.INTERACTIVE_SPRITE);
		optionsButton = GameObject.FindGameObjectWithTag(Tags.MENU_SETTINGS_BUTTON).GetComponent<Button>();
	}

	public void OpenPanel() {
		//if (!EventSystem.current.IsPointerOverGameObject ()) {
			if (panel) {
				panel.SetActive (true);
				if(gameObject.GetComponent<AudioSource>()!= null)
					gameObject.GetComponent<AudioSource> ().Play ();
				if(helper)
					helper.SetActive (false);
				//DeactivateColliders ();
				movableGO.DeactivateColliders();
			//	GameObject optionsButton = GameObject.FindGameObjectWithTag(Tags.MENU_SETTINGS_BUTTON);
			if (optionsButton)
				optionsButton.enabled = false;
			}
			else
				Debug.Log ("Panel was not found!");
	//	}
	}
	public void ClosePanel() {
		//if (!EventSystem.current.IsPointerOverGameObject ()) {
		if (panel) {
			panel.SetActive (false);
			if(gameObject.GetComponent<AudioSource>()!= null)
				gameObject.GetComponent<AudioSource> ().Play ();
			if(helper)
				helper.SetActive (true);
			//DeactivateColliders ();
			movableGO.ActivateColliders();
			if (optionsButton)
				optionsButton.enabled = true;
		}
		else
			Debug.Log ("Panel was not found!");
		//	}
	}
	/*
	void DeactivateColliders() {
		foreach (var item in colliderHolders) {
			item.GetComponent<Collider2D> ().enabled = false;
		}
	}

	public void ActivateColliders() {
		foreach (var item in colliderHolders) {
			item.GetComponent<Collider2D>().enabled = true;
		}
	}
	*/
}
