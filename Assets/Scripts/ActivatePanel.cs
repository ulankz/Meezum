using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using MeezumGame;
public class ActivatePanel : MonoBehaviour {

	public CanvasGroup panelCG;
	public CanvasGroup currentPanelCG;
	public GameObject helper;
	//public GameObject[] colliderHolders;
	//private InteractiveSpriteTracker movableGO;

	public delegate void ChangeInteractiveColliderState(bool activate);
	public static event ChangeInteractiveColliderState onInteractiveColliderChanged;
	Button optionsButton;
	void Start() {
	//	movableGO = GameObject.FindGameObjectWithTag (Tags.MOVABLE_OBJECT).GetComponent<InteractiveSpriteTracker> ();
		//colliderHolders = GameObject.FindGameObjectsWithTag (Tags.INTERACTIVE_SPRITE);
		optionsButton = GameObject.FindGameObjectWithTag(Tags.MENU_SETTINGS_BUTTON).GetComponent<Button>();
		//currentPanelCG = transform.parent.parent.parent.parent.GetComponent<CanvasGroup> ();
	}

	public void OpenPanel ()
	{
		//if (!EventSystem.current.IsPointerOverGameObject ()) {
		if (currentPanelCG != null) {
			currentPanelCG.alpha = 0;
			currentPanelCG.interactable = false;
			currentPanelCG.transform.SetAsFirstSibling ();
		} 
		if (panelCG != null) {
			panelCG.alpha = 1;
			panelCG.interactable = true;
			panelCG.transform.SetAsLastSibling ();
		}
		if (currentPanelCG || panelCG) {
			Debug.Log ("Panel was found!");
		}
		else{
				Debug.Log ("Panel was not found!");
		}
			if (gameObject.GetComponent<AudioSource> () != null)
				gameObject.GetComponent<AudioSource> ().Play ();
			if (helper)
				helper.SetActive (false);
			//DeactivateColliders ();
			//movableGO.DeactivateColliders();
			if (onInteractiveColliderChanged != null)
				onInteractiveColliderChanged (false);
			//	GameObject optionsButton = GameObject.FindGameObjectWithTag(Tags.MENU_SETTINGS_BUTTON);
			if (optionsButton)
				optionsButton.enabled = false;
			
	}
	public void ClosePanel() {
		//if (!EventSystem.current.IsPointerOverGameObject ()) {
		if (optionsButton)
			optionsButton.enabled = true;
		
		if (panelCG != null) {
			panelCG.alpha = 0;
			panelCG.interactable = false;
			panelCG.transform.SetAsFirstSibling ();
		} else if (currentPanelCG != null) {
			currentPanelCG.alpha = 0;
			currentPanelCG.interactable = false;
			currentPanelCG.transform.SetAsFirstSibling ();
		} else {
			Debug.Log ("Panel was not found!");
		}
		if(gameObject.GetComponent<AudioSource>()!= null)
			gameObject.GetComponent<AudioSource> ().Play ();
		if(helper)
			helper.SetActive (true);
		//DeactivateColliders ();
		//movableGO.ActivateColliders();
		if (onInteractiveColliderChanged != null)
			onInteractiveColliderChanged (true);
		
	}
}
