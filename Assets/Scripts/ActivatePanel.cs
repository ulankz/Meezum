using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ActivatePanel : MonoBehaviour {
	
	public GameObject panel;
	public GameObject helper;
	public List<Collider2D> colliders;

	void Start() {
	}

	void OnMouseUpAsButton() {
		if (!EventSystem.current.IsPointerOverGameObject ()) {
			if (panel) {
				panel.SetActive (true);
				gameObject.GetComponent<AudioSource> ().Play ();
				helper.SetActive (false);
				DeactivateColliders ();

				GameObject optionsButton = GameObject.Find ("OptionsButton");
				if (optionsButton)
					optionsButton.SetActive (false);
			}
			else
				Debug.Log ("Panel was not found!");
		}
	}

	void DeactivateColliders() {
		foreach (var item in colliders) {
			item.enabled = false;
		}
	}

	public void ActivateColliders() {
		foreach (var item in colliders) {
			item.enabled = true;
		}
	}
}
