using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using System.Linq;
using System;
using MeezumGame;
using UnityEngine.SceneManagement;
public class MainUiManager : MonoBehaviour,UIManagable {

	#region PRIVATE MEMBERS
	public GameObject playerTotem;
	public InputField pnlRegNameInput;
	public List<Button> pnlRegAvaBtns;
	public Button pnlRegOkBtn;
	public Text pnlRegNameTxt;
	[SerializeField]
	public GameObject player_choice_pnl;
	public Button pnlChoosePlayer;
	[SerializeField]
	public Button[] playerAvatarButtons;
	[SerializeField]
	public Sprite[] avatarSprites;
	public string avatarSpritesPath = "GeneralUI";
	[SerializeField]
	public Button confirmChangeCurrentUser;
	[SerializeField]
	public GameObject missionsPanel;
	[SerializeField]
	Button[] chooseMissionButtons;
	public CanvasGroup missionsPanelCG;
	public Button optionsButton;
	public Button exitButton;
	public GameObject optionsPanel;

	public CanvasGroup optionsPanelCG;
	#endregion
	[SerializeField]
	public Transform[] inGameUIObjects;
	public delegate void ClickAction(string plName, string ava);
	public static event ClickAction OnRegOkClickEvent;

	public delegate List<Player> ChoosePlayerAction();
	public static event ChoosePlayerAction OnChooseClickEvent;
	public delegate void OnChangeCurrentUserClickAction(Int32 id);
	public static event OnChangeCurrentUserClickAction OnChangeCurrentUsersClickEvent;
	[SerializeField]
	string choosenPlayerName;
	// Use this for initialization

	[SerializeField]
	public Canvas canvas;
	[SerializeField]
	public Canvas generalCanvas;

	[SerializeField]
	public GameObject tvPanel;
	public CanvasGroup tvPanelCG;

	[SerializeField]
	public GameObject miniGamePanel;
	public CanvasGroup miniGamePanelCG;
	[SerializeField]
	public GameObject cupboardPanel;
	public CanvasGroup cupboardPanelCG;


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



		avatarSprites = Resources.LoadAll<Sprite> (avatarSpritesPath);
		if (avatarSprites.Count() > 0) {
			//print ("Sprites are loaded");
		} else {
			print ("Sprites are not loaded");

		}

			//	playerAvatarButtons = new Button[6];
			playerAvatarButtons = GameObject.FindGameObjectsWithTag (Tags.CHOICE_PANEL_PLAYER_BUTTON).Select (b => b.GetComponent<Button> ()).ToArray ();
			Array.Sort (playerAvatarButtons, delegate(Button b1, Button b2) {
				return b1.gameObject.name.CompareTo (b2.gameObject.name);
			});

		for (int i = 0; i < playerAvatarButtons.Count (); i++) {
			Button b = playerAvatarButtons [i];
			b.interactable = false;
			print ("Adds button clock listener");
			b.onClick.AddListener (delegate {
				SelectPlayerButton (b);
			});
		}

		generalCanvas.worldCamera = Camera.main;
		for (int i = 0; i < playerAvatarButtons.Count (); i++) {
			Button b = playerAvatarButtons [i];
			b.interactable = false;
			print ("Adds button clock listener");
			b.onClick.AddListener (delegate {
				SelectPlayerButton (b);
			});
		}
		optionsButton = GameObject.FindGameObjectWithTag (Tags.MENU_SETTINGS_BUTTON).GetComponent<Button>();
		exitButton = GameObject.FindGameObjectWithTag (Tags.MENU_EXIT_BUTTON).GetComponent<Button>();
		exitButton.image.enabled = false;
		Debug.Log ("START IS CALLED FROM MAIN_UI_MANAGER");
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


	private void OnLevelFinishedLoading(Scene scene,LoadSceneMode mode){
		
		switch(scene.name){
		case Scenes.GUEST_ROOM_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			Camera camera = Camera.main;
			generalCanvas.worldCamera = camera;
			/*
			exitButton.image.enabled = false;
			optionsButton.gameObject.GetComponent<RectTransform> ().anchorMin = new Vector2 (0, 1);
			optionsButton.gameObject.GetComponent<RectTransform> ().anchorMax = new Vector2 (0, 1);
			optionsButton.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (0,0);
			optionsButton.gameObject.GetComponent<RectTransform> ().pivot = new Vector2 (0,1);
*/
			//inGameUIObjects = new Transform[canvas.transform.childCount];

			Debug.Log ("NUMBER OF CHILD ELEMENTS INSIDE CANVAS " + canvas.transform.childCount);

			tvPanel = GameObject.FindGameObjectWithTag (Tags.TV_MIRROR_PANEL);
			tvPanelCG = tvPanel.GetComponent<CanvasGroup> ();
			tvPanel.transform.SetParent (generalCanvas.transform);
			tvPanel.transform.SetAsFirstSibling ();
			miniGamePanel = GameObject.FindGameObjectWithTag (Tags.MINI_GAME_PANEL);
			miniGamePanelCG = miniGamePanel.GetComponent<CanvasGroup> ();
			miniGamePanel.transform.SetParent (generalCanvas.transform);
			miniGamePanel.transform.SetAsFirstSibling ();
			cupboardPanel = GameObject.FindGameObjectWithTag (Tags.CUPBOARD_PANEL);
			cupboardPanelCG = cupboardPanel.GetComponent<CanvasGroup> ();
			cupboardPanel.transform.SetParent (generalCanvas.transform);
			cupboardPanel.transform.SetAsFirstSibling ();
						//HidePanelMissions (true);
			break;
		case Scenes.MAIN_MENU_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			generalCanvas = GameObject.FindGameObjectWithTag (Tags.GENERAL_CANVAS).GetComponent<Canvas> ();
			generalCanvas.worldCamera = Camera.main;
			player_choice_pnl = GameObject.FindGameObjectWithTag (Tags.CHOICE_PANEL);
			optionsButton = GameObject.FindGameObjectWithTag (Tags.MENU_SETTINGS_BUTTON).GetComponent<Button> ();
			exitButton = GameObject.FindGameObjectWithTag (Tags.MENU_EXIT_BUTTON).GetComponent<Button> ();
			exitButton.image.enabled = false;
			optionsButton.gameObject.GetComponent<RectTransform> ().anchorMin = new Vector2 (1, 0);
			optionsButton.gameObject.GetComponent<RectTransform> ().anchorMax = new Vector2 (1, 0);
			optionsButton.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-60,0);
			optionsButton.gameObject.GetComponent<RectTransform> ().pivot = new Vector2 (1,0);

			confirmChangeCurrentUser = GameObject.FindGameObjectWithTag (Tags.CONFIRM_CHANGE_CURRENT_USER).GetComponent<Button> ();
			confirmChangeCurrentUser.onClick.AddListener (delegate {
				ChangeCurrentUser ();
			});
			for (int i = 0; i < playerAvatarButtons.Count (); i++) {
				Button b = playerAvatarButtons [i];
				b.interactable = false;
				print ("Adds button clock listener");
				b.onClick.AddListener (delegate {
					SelectPlayerButton (b);
				});
			}
			if (miniGamePanel != null)
				DestroyImmediate (miniGamePanel);
			if (tvPanel != null)
				DestroyImmediate (tvPanel);
			if (cupboardPanel != null)
				DestroyImmediate (cupboardPanel);
			
			optionsPanel = GameObject.FindGameObjectWithTag (Tags.OPTIONS_PANEL);
			optionsPanelCG = optionsPanel.GetComponent<CanvasGroup>();
			missionsPanel = GameObject.FindGameObjectWithTag (Tags.MISSION_PANEL);
			missionsPanelCG = missionsPanel.GetComponent<CanvasGroup>();
			chooseMissionButtons = GameObject.FindGameObjectsWithTag (Tags.CHOOSE_MISSION_BUTTON).Select (b => b.GetComponent<Button> ()).ToArray ();
			foreach (Button b in chooseMissionButtons) {
				b.onClick.AddListener (delegate{
					
					missionsPanelCG.alpha = 0;
					missionsPanelCG.blocksRaycasts = false;
					missionsPanel.transform.SetAsFirstSibling ();
					generalCanvas.GetComponent<TransitionScript>().moveToScene();
				});
			}
			break;
		default:
			//HidePanelMissions(false);
			break;
		}

	}
	void OnEnable(){
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}
	void OnDisable(){
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}
}
