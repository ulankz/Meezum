using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractWithObjectOnClick_v02 : MonoBehaviour {

	public int messItemIndex;
	public Vector2 offset;
	public Vector2 newScale;
	public Vector3 newRotation;
	public bool isTransformRequired;
	public bool hideAfterInteraction;
	public bool isSubstituteRequired;

	ScoreManager scoreManager;

	private List<MessItem> messItems;


	// Use this for initialization
	void Start () {
		messItems = XMLManager.ins.playerDB.list[0].messItems;

		GameObject scorePanel = GameObject.Find ("score_panel");
		if (scorePanel) {
			scoreManager = scorePanel.GetComponent<ScoreManager> ();
		}
	}
		
	private void ApplyTransformation() {
		gameObject.transform.eulerAngles -= newRotation;
		gameObject.transform.localScale = new Vector3(newScale.x, newScale.y, 1);
		gameObject.transform.position = gameObject.transform.position + new Vector3(offset.x, offset.y, 0);
		isTransformRequired = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

	void OnMouseUpAsButton() {
		if (gameObject.GetComponent<Renderer> ().enabled) {
			gameObject.GetComponent<AudioSource> ().Play ();
			if (isTransformRequired) {
				ApplyTransformation ();
				//gameObject.GetComponent<AudioSource>().Play();
			} else if (hideAfterInteraction) {
				gameObject.GetComponent<Renderer> ().enabled = false;
			} else if (isSubstituteRequired) {
				gameObject.GetComponent<Renderer> ().enabled = false;
				GameObject.Find ("order" + gameObject.name.Substring (4)).GetComponent<Renderer> ().enabled = true;
			}

			// Update playerDB
			messItems [messItemIndex].status = MessItemStatus.Cleaned;
			XMLManager.ins.playerDB.list [0].cleanedMessItems += 1;

			scoreManager.UpdateScores ();

			// Nullify the number of cleaned items if there are no more queued items
			if (XMLManager.ins.playerDB.list [0].cleanedMessItems == messItems.Count) {
				NullifyCleanedItems ();
				XMLManager.ins.playerDB.list [0].cleanedMessItems = 0;
			}
		}
	}
		
	void NullifyCleanedItems() {
		foreach (MessItem item in messItems) {
			item.status = MessItemStatus.Queued;
		}
	}
}
