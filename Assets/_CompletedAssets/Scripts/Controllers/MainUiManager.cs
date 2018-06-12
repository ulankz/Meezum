using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;
using System;
using MeezumGame;
public class MainUiManager : MonoBehaviour,UIManagable {

	#region PRIVATE MEMBERS
	public GameObject playerTotem;
	public InputField pnlRegNameInput;
	public List<Button> pnlRegAvaBtns;
	public Button pnlRegOkBtn;
	public Text pnlRegNameTxt;
	[SerializeField]
	private GameObject player_choice_pnl;
	public Button pnlChoosePlayer;
	[SerializeField]
	private Button[] playerAvatarButtons;
	[SerializeField]
	private Sprite[] avatarSprites;
	private string avatarSpritesPath = "GeneralUI";
	[SerializeField]
	private Button confirmChangeCurrentUser;
	#endregion

	public delegate void ClickAction(string plName, string ava);
	public static event ClickAction OnRegOkClickEvent;

	public delegate List<Player> ChoosePlayerAction();
	public static event ChoosePlayerAction OnChooseClickEvent;
	public delegate void OnChangeCurrentUserClickAction(Int32 id);
	public static event OnChangeCurrentUserClickAction OnChangeCurrentUsersClickEvent;
	[SerializeField]
	string choosenPlayerName;
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


		player_choice_pnl = GameObject.FindGameObjectWithTag (Tags.CHOICE_PANEL);
		if (player_choice_pnl != null) {
			playerAvatarButtons = GameObject.FindGameObjectsWithTag (Tags.CHOICE_PANEL_PLAYER_BUTTON).Select (b => b.GetComponent<Button> ()).ToArray ();
			Array.Sort(playerAvatarButtons,delegate(Button b1, Button b2) {
				return b1.gameObject.name.CompareTo(b2.gameObject.name);
			});
		}
		avatarSprites = Resources.LoadAll<Sprite> (avatarSpritesPath);
		if (avatarSprites.Count() > 0) {
			//print ("Sprites are loaded");
		} else {
			print ("Sprites are not loaded");

		}
		confirmChangeCurrentUser = GameObject.FindGameObjectWithTag (Tags.CONFIRM_CHANGE_CURRENT_USER).GetComponent<Button>();
		confirmChangeCurrentUser.onClick.AddListener (delegate{
			ChangeCurrentUser();
		});
		for(int i =0; i <  playerAvatarButtons.Count(); i++){
			Button b = playerAvatarButtons[i];
			b.interactable = false;
			b.onClick.AddListener (delegate{
				SelectPlayerButton(b);
			});
		}
	}
	private void SelectPlayerButton(Button b){
		choosenPlayerName = b.name;
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
		List<Player> players = new List<Player>();
		if (OnChooseClickEvent != null) {
			players = OnChooseClickEvent ();
		}
		LoadAllUsersInChoicePanel (players);

	}
	private void ChangeCurrentUser(){
		if (OnChangeCurrentUsersClickEvent != null) {
			if (choosenPlayerName != "")
				OnChangeCurrentUsersClickEvent (Int32.Parse(choosenPlayerName));
			else {
				return;
			}
		}
	}
	public void LoadAllUsersInChoicePanel(List<Player> players){
		int i = 0;
		Debug.Log ("LOAD ALL PLAYERS FROM PLAYER LIST " + players.Count);

		foreach (Player p in players) {
			Debug.Log (p.Id + " " + p.Name+ " " + p.IsActive);
			playerAvatarButtons [i].image.sprite = getSpriteByName (p.Avatar);
			playerAvatarButtons [i].GetComponentInChildren<Text> ().text = p.Name;
			playerAvatarButtons [i].name = p.Id.ToString();
			if (p.IsActive) {
				playerAvatarButtons [i].interactable = false;
			} else {
				playerAvatarButtons [i].interactable = true;
			}
			i++;
		}
	}
	private Sprite getSpriteByName(string name){
		if (name == " ") {
			Debug.Log ("SPRITE NAME CANNOT BE EMPTY, PLEASE SPECIFY ONE");	
			return null;
		}
		foreach(Sprite sprite in avatarSprites){
			if (name.Equals (sprite.name))
				return sprite;
		}
		return null;
	}
	private void UpdatePlayerAvatar(){
		
	}

}
