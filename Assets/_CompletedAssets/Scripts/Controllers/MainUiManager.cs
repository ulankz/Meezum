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
	public Button storeButton;
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

	public GameObject uiAlertView;
	#region FOREST_SCENE_RELATED_VARIABLES
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

	#endregion
	#region COMICS_REALTED_VARIABLES
	public GameObject comicsPanelGO;
	public CanvasGroup comicsPanelCG;
	public Button comicsStartButton;
	public Camera mainCamera;
	#endregion
	#region MAZE_REALTED_VARIABLES
	public GameObject mazePanelGO;
	public CanvasGroup mazePanelCG;
	#endregion
	#region GAMEWORDS_REALTED_VARIABLES
	public GameObject gameWordsPanelGO;
	public CanvasGroup gameWordsPanelCG;
	#endregion
	void Start () {
		mainCamera = Camera.main;
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

	/*	for (int i = 0; i < playerAvatarButtons.Count (); i++) {
			Button b = playerAvatarButtons [i];
			b.interactable = false;
			print ("Adds button clock listener");
			b.onClick.AddListener (delegate {
				SelectPlayerButton (b);
			});
		}
*/
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
		storeButton = GameObject.FindGameObjectWithTag (Tags.STORE_BUTTON).GetComponent<Button>();
		exitButton = GameObject.FindGameObjectWithTag (Tags.MENU_EXIT_BUTTON).GetComponent<Button>();
		exitButton.image.enabled = false;
		missionsPanel = GameObject.FindGameObjectWithTag (Tags.MISSION_PANEL);
		missionsPanelCG = missionsPanel.GetComponent<CanvasGroup>();
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

	private void ChangeGeneralUIPosition(){
		optionsButton.gameObject.GetComponent<RectTransform> ().anchorMin = new Vector2 (0, 1);
		optionsButton.gameObject.GetComponent<RectTransform> ().anchorMax = new Vector2 (0, 1);
		optionsButton.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (20,-20);
		optionsButton.gameObject.GetComponent<RectTransform> ().pivot = new Vector2 (0,1);
		optionsButton.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (40, 58);
		exitButton.image.enabled = true;
		storeButton.image.enabled = false;
		optionsButton.enabled = true;
		optionsButton.transform.SetAsLastSibling ();
		exitButton.transform.SetAsLastSibling ();
		exitButton.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-20, -20);
		exitButton.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (40, 58);
	}
	private void ResetGeneralUI(){
		storeButton.image.enabled = true;
		exitButton.image.enabled = false;
		optionsButton.gameObject.GetComponent<RectTransform> ().anchorMin = new Vector2 (1, 0);
		optionsButton.gameObject.GetComponent<RectTransform> ().anchorMax = new Vector2 (1, 0);
		optionsButton.gameObject.GetComponent<RectTransform> ().anchoredPosition = new Vector2 (-60, 0);
		optionsButton.gameObject.GetComponent<RectTransform> ().pivot = new Vector2 (1, 0);
		optionsButton.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (69, 58);
		exitButton.gameObject.GetComponent<RectTransform> ().sizeDelta = new Vector2 (69, 58);
	}
	private void OnLevelFinishedLoading(Scene scene,LoadSceneMode mode){
		
		switch(scene.name){
		case Scenes.GUEST_ROOM_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			mainCamera = Camera.main;
			//GlobalSettingsPanel.Instance.camera = mainCamera.gameObject;
			//GlobalSettingsPanel.Instance.bg_music = mainCamera.GetComponent<AudioSource> ();
			GlobalSettingsPanel.Instance.sceneName = SceneManager.GetActiveScene ().name;
			generalCanvas.worldCamera = mainCamera;
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
			mainCamera = Camera.main;
			//GlobalSettingsPanel.Instance.camera = mainCamera.gameObject;
			//GlobalSettingsPanel.Instance.bg_music = mainCamera.GetComponent<AudioSource> ();
			GlobalSettingsPanel.Instance.sceneName = SceneManager.GetActiveScene ().name;
			generalCanvas.worldCamera = mainCamera;
			player_choice_pnl = GameObject.FindGameObjectWithTag (Tags.CHOICE_PANEL);
			optionsButton = GameObject.FindGameObjectWithTag (Tags.MENU_SETTINGS_BUTTON).GetComponent<Button> ();
			exitButton = GameObject.FindGameObjectWithTag (Tags.MENU_EXIT_BUTTON).GetComponent<Button> ();
			missionsPanel = GameObject.FindGameObjectWithTag (Tags.MISSION_PANEL);
			missionsPanelCG = missionsPanel.GetComponent<CanvasGroup> ();
			//optionsButton.enabled = false;
			storeButton = GameObject.FindGameObjectWithTag (Tags.STORE_BUTTON).GetComponent<Button> ();
			ResetGeneralUI ();
			missionsPanelCG.alpha = 0;
			missionsPanel.transform.SetAsFirstSibling ();
			confirmChangeCurrentUser = GameObject.FindGameObjectWithTag (Tags.CONFIRM_CHANGE_CURRENT_USER).GetComponent<Button> ();
			confirmChangeCurrentUser.onClick.AddListener (delegate {
				ChangeCurrentUser ();
			});
			/*for (int i = 0; i < playerAvatarButtons.Count (); i++) {
				Button b = playerAvatarButtons [i];
				b.interactable = false;
				print ("Adds button click listener");
				b.onClick.AddListener (delegate {
					SelectPlayerButton (b);
				});
			}
*/
			if (miniGamePanel != null)
				DestroyImmediate (miniGamePanel);
			if (tvPanel != null)
				DestroyImmediate (tvPanel);
			if (cupboardPanel != null)
				DestroyImmediate (cupboardPanel);
			if (comicsPanelGO != null)
				DestroyImmediate (comicsPanelGO);
			if (mazePanelGO != null)
				DestroyImmediate (mazePanelGO);
			optionsPanel = GameObject.FindGameObjectWithTag (Tags.OPTIONS_PANEL);
			optionsPanelCG = optionsPanel.GetComponent<CanvasGroup>();
			//missionsPanel = GameObject.FindGameObjectWithTag (Tags.MISSION_PANEL);
			//missionsPanelCG = missionsPanel.GetComponent<CanvasGroup>();
			chooseMissionButtons = GameObject.FindGameObjectsWithTag (Tags.CHOOSE_MISSION_BUTTON).Select (b => b.GetComponent<Button> ()).ToArray ();
			foreach (Button b in chooseMissionButtons) {
				b.onClick.AddListener (delegate{
					generalCanvas.GetComponent<TransitionScript>().moveToScene();
					//missionsPanelCG.alpha = 0;
					//missionsPanelCG.blocksRaycasts = false;
					//missionsPanel.transform.SetAsFirstSibling ();

				});
			}

			break;
		case Scenes.COMICS_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			mainCamera = Camera.main;
			generalCanvas.worldCamera = mainCamera;
			//GlobalSettingsPanel.Instance.camera = mainCamera.gameObject;
			//GlobalSettingsPanel.Instance.bg_music = mainCamera.GetComponent<AudioSource> ();
			GlobalSettingsPanel.Instance.sceneName = SceneManager.GetActiveScene ().name;
			comicsPanelGO = GameObject.FindGameObjectWithTag (Tags.COMICS_PANEL);
			if (comicsPanelGO) {
				comicsStartButton = comicsPanelGO.GetComponentInChildren<Button> ();
				comicsPanelCG = comicsPanelGO.GetComponent<CanvasGroup> ();
				comicsPanelGO.transform.SetParent (generalCanvas.transform);
				//comicsPanelGO.transform.SetAsFirstSibling ();

			}
			ChangeGeneralUIPosition();
			break;
		case Scenes.MAZE_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			mainCamera = Camera.main;
			generalCanvas.worldCamera = mainCamera;
			//GlobalSettingsPanel.Instance.camera = mainCamera.gameObject;
			//GlobalSettingsPanel.Instance.bg_music = mainCamera.GetComponent<AudioSource> ();
			  GlobalSettingsPanel.Instance.sceneName = SceneManager.GetActiveScene ().name;

			mazePanelGO = GameObject.FindGameObjectWithTag (Tags.MAZE_PANEL);
			if (mazePanelGO) {
				mazePanelCG = mazePanelGO.GetComponent<CanvasGroup> ();
				mazePanelGO.transform.SetParent (generalCanvas.transform);
				//comicsPanelGO.transform.SetAsFirstSibling ();

			}
			ChangeGeneralUIPosition();
			if (comicsPanelGO != null)
				DestroyImmediate (comicsPanelGO);
			if (gameWordsPanelGO != null)
				DestroyImmediate (gameWordsPanelGO);
			break;
		case Scenes.GAME_OF_WORDS_SCENE:
			Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			mainCamera = Camera.main;
			generalCanvas.worldCamera = mainCamera;
		//	GlobalSettingsPanel.Instance.camera = mainCamera.gameObject;
			//GlobalSettingsPanel.Instance.bg_music = mainCamera.GetComponent<AudioSource> ();
			  GlobalSettingsPanel.Instance.sceneName = SceneManager.GetActiveScene ().name;

			gameWordsPanelGO = GameObject.FindGameObjectWithTag (Tags.GAME_WORDS_UI_MANAGER);
			if (gameWordsPanelGO) {
				gameWordsPanelCG = gameWordsPanelGO.GetComponent<CanvasGroup> ();
				gameWordsPanelGO.transform.SetParent (generalCanvas.transform);
				//comicsPanelGO.transform.SetAsFirstSibling ();

			}
			ChangeGeneralUIPosition();
			if (mazePanelGO != null)
				DestroyImmediate (mazePanelGO);
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
