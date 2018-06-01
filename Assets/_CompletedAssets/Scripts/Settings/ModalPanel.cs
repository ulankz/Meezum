using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class ModalPanel : MonoBehaviour {

	public Text message;
	public Button okBtn;
	public Button cancelBtn;
	public GameObject modalPanelObject;

	private static ModalPanel modalPanel;

	public static ModalPanel Instance () {
		if (!modalPanel) {
			modalPanel = FindObjectOfType (typeof(ModalPanel)) as ModalPanel;
			if (!modalPanel)
				Debug.LogError ("There needs to be one active ModalPanel script on a GameObject in your scene.");
		}
		return modalPanel;
	}

	public void Option(string message, UnityAction okEvent, UnityAction cancelEvent) {
		modalPanelObject.SetActive (true);

		okBtn.onClick.RemoveAllListeners();
		okBtn.onClick.AddListener (okEvent);
		okBtn.onClick.AddListener (ClosePanel);

		cancelBtn.onClick.RemoveAllListeners();
		cancelBtn.onClick.AddListener (cancelEvent);
		cancelBtn.onClick.AddListener (ClosePanel);

		this.message.text = message;
		okBtn.gameObject.SetActive (true);
		cancelBtn.gameObject.SetActive (true);
	}

	void ClosePanel () {
		modalPanelObject.SetActive (false);
	}

}
