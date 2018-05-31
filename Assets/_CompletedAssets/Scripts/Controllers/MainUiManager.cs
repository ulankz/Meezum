using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;

public class MainUiManager : MonoBehaviour,UIManagable {

	#region PRIVATE MEMBERS
	public GameObject playerTotem;
	public InputField pnlRegNameInput;
	public List<Button> pnlRegAvaBtns;
	public Button pnlRegOkBtn;
	public Text pnlRegNameTxt;

	public Button pnlChoosePlayer;
	#endregion

	public delegate void ClickAction(string plName, string ava);
	public static event ClickAction OnRegOkClickEvent;

	public delegate List<string> ChoosePlayerAction();
	public static event ChoosePlayerAction OnChooseClickEvent;


	// Use this for initialization
	void Start () {

		// -------------Registration-------------
		// Input field
		pnlRegNameInput.onValueChanged.AddListener (delegate {
			ValueChangeCheck ();
		});

		// Avatar buttons
		foreach (Button btn in pnlRegAvaBtns) {
			btn.onClick.AddListener (delegate {
				ChangeTotemSprite (btn);
			});
		}

		// Okay button
		pnlRegOkBtn.onClick.AddListener (delegate {
			RegisterUser ();
		});

		// -------------Choose player-------------
		// Choose button
		pnlChoosePlayer.onClick.AddListener (delegate {
			ChooseUser ();
		});

	}

	public void ValueChangeCheck() {
		pnlRegNameTxt.text =  pnlRegNameInput.text;
	}

	public void ChangeTotemSprite(Button btn) {
		if (playerTotem.activeSelf==false)
			playerTotem.SetActive (true);
		playerTotem.GetComponent<Image> ().sprite = btn.GetComponent<Image>().sprite;
	}

	private void RegisterUser() {
		if (pnlRegNameTxt.text.Trim ().Length != 0 && playerTotem.activeSelf) {
			if (OnRegOkClickEvent != null) {
				string plName = pnlRegNameTxt.text;
				string ava = playerTotem.GetComponent<Image> ().sprite.name.Split ('_').Last ();
				// Clear the input field and totem image
				pnlRegNameInput.text = "";
				pnlRegNameTxt.text = "";
				playerTotem.SetActive (false);

				OnRegOkClickEvent (plName, ava);
			}
		} else {
			Debug.Log ("You either have not chosen the avatar or forgotten to enter the name. Please, do it to continue!");
		}
	}

	private void ChooseUser() {
		List<string> players = new List<string>();
		if (OnChooseClickEvent != null) {
			players = OnChooseClickEvent ();
		}

		foreach (string str in players) {
			string[] plInfo = str.Split (' ');
			Debug.Log (plInfo [0] + " " + plInfo [1] + " " + plInfo [2]);
		}
	}
}
