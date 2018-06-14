using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using MeezumGame;
using UnityEngine.SceneManagement;

public class GlobalSettingsPanel : MonoBehaviour {

	public Button pnl_btn_sound;
	public Button pnl_btn_music;
	[SerializeField]
	private GameObject PanelMissions;
	/*public GameObject canvas;
	public GameObject globalSettingsPanel;
	public GameObject general;
	public GameObject custom_general;
	public GameObject settings_btn;
	public GameObject quit_btn;
	public GameObject store_btn;
	public Button timer_quit_btn;
	public Button timer_alarm_ok_btn;
	private bool everythingIsSetup = false;
	string sceneName = "", prevSceneName = "";*/
	public GameObject camera;
	public AudioSource bg_music;
	public string sceneName;
	[SerializeField]
	private Canvas generalCanvas;
	private static GlobalSettingsPanel instance = null;

	private GlobalSettingsPanel()
	{
	}

	public static GlobalSettingsPanel Instance
	{
		get
		{ 
			if (instance == null) 
			{
				instance = new GlobalSettingsPanel ();
			}
			return instance;
		}
	}

	private void Awake() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
		generalCanvas = GetComponent<Canvas> ();
	}

	void Start() {
		
		camera = GlobalGameManager.instance.gameObject;//GameObject.Find ("Main Camera");
		Debug.Log ("GLOBAL SETTINGS PANEL START IS CALLED");

		bg_music = camera.GetComponent<AudioSource> ();
		ColorBlock cb = pnl_btn_music.GetComponent<Button> ().colors;
		if (PlayerPrefs.GetInt ("musicIsOn", 1) == 1) {
			cb.normalColor = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
			pnl_btn_music.GetComponent<Button> ().colors = cb;
			bg_music.Play ();
		} else {
			cb.normalColor = new Color32(0x6F, 0x6F, 0x6F, 0xFF);
			pnl_btn_music.GetComponent<Button> ().colors = cb;
			bg_music.Pause ();	
		}

		pnl_btn_music.GetComponent<Button> ().onClick.AddListener (delegate {
			if (bg_music.isPlaying) {
				cb.normalColor = new Color32(0x6F, 0x6F, 0x6F, 0xFF);
				pnl_btn_music.GetComponent<Button> ().colors = cb;
				bg_music.Pause ();
				PlayerPrefs.SetInt ("musicIsOn", 0);
			} else {
				cb.normalColor = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
				pnl_btn_music.GetComponent<Button> ().colors = cb;
				bg_music.Play();
				PlayerPrefs.SetInt ("musicIsOn", 1);
			}
		});

		 sceneName = SceneManager.GetActiveScene ().name;
		ColorBlock cb_sound = pnl_btn_sound.GetComponent<Button> ().colors;
		if (PlayerPrefs.GetInt ("soundIsOn", 1) == 1) {
			cb_sound.normalColor = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
			pnl_btn_sound.GetComponent<Button> ().colors = cb_sound;
			toggleSound (sceneName, false);
		} else {
			cb_sound.normalColor = new Color32(0x6F, 0x6F, 0x6F, 0xFF);
			pnl_btn_sound.GetComponent<Button> ().colors = cb_sound;
			toggleSound (sceneName, true);
		}

		pnl_btn_sound.GetComponent<Button> ().onClick.AddListener (delegate {
			if (PlayerPrefs.GetInt ("soundIsOn", 1) == 1) {
				cb_sound.normalColor = new Color32(0x6F, 0x6F, 0x6F, 0xFF);
				pnl_btn_sound.GetComponent<Button> ().colors = cb_sound;
				toggleSound (sceneName, true);
				PlayerPrefs.SetInt ("soundIsOn", 0);
			} else {
				cb_sound.normalColor = new Color32(0xFF, 0xFF, 0xFF, 0xFF);
				pnl_btn_sound.GetComponent<Button> ().colors = cb_sound;
				toggleSound (sceneName, false);
				PlayerPrefs.SetInt ("soundIsOn", 1);
			}
		});
	}

	void toggleSound(string sceneName, bool on) {
		switch (sceneName) {
		case "Forest":
			GameObject.Find ("Door").GetComponent<AudioSource> ().mute = on;
			GameObject.Find ("Star").GetComponent<AudioSource> ().mute = on;
			break;
		case "GuestroomSwipe":
			for (int i = 0; i < GameObject.Find ("Constants").transform.childCount; i++) {
				AudioSource audio = GameObject.Find ("Constants").transform.GetChild (i).gameObject.GetComponent<AudioSource> ();
				if (audio != null) {
					audio.mute = on;
				}
			}
			for (int i = 0; i < GameObject.Find ("Characters").transform.childCount; i++) {
				AudioSource audio = GameObject.Find ("Characters").transform.GetChild (i).gameObject.GetComponent<AudioSource> ();
				if (audio != null) {
					audio.mute = on;
				}
			}
			for (int i = 0; i < GameObject.Find ("Mess").transform.childCount; i++) {
				AudioSource audio = GameObject.Find ("Mess").transform.GetChild (i).gameObject.GetComponent<AudioSource> ();
				if (audio != null) {
					audio.mute = on;
				}
			}
			break;
		default:
			break;
		}

	}

	/*void Update() {
		sceneName = SceneManager.GetActiveScene ().name;
		if (sceneName != prevSceneName) {
			everything_Is_Setup = false;
		}
		prevSceneName = sceneName;
		if (!everything_Is_Setup) {
			switch (sceneName) {
			case "Forest":
				RectTransform canvasRect = canvas.GetComponent<RectTransform> ();
				custom_general.SetActive (false);
				quit_btn.SetActive (false);
				store_btn.SetActive (true);
				RectTransform store_btn_rect = store_btn.GetComponent<RectTransform> ();
				settings_btn.GetComponent<RectTransform>().localPosition = new Vector3 (store_btn_rect.localPosition.x - (store_btn_rect.sizeDelta.x), store_btn_rect.localPosition.y, 0);
				timer_quit_btn.onClick.AddListener (delegate {
					general.SetActive(true);
				});
				timer_alarm_ok_btn.onClick.AddListener (delegate {
					general.SetActive(true);
				});
				break;
			case "Comics":
			case "Maze":
				canvas.GetComponent<RectTransform> ().sizeDelta = GameObject.Find ("Canvas").GetComponent<RectTransform> ().sizeDelta;
				general.SetActive (false);
				custom_general.SetActive (true);
				quit_btn.SetActive (true);
				//settings_btn. = new Vector3 (85, -70, 0);
				//quit_btn.transform.position = new Vector3 (-85, -70, 0);
				store_btn.SetActive (false);
				timer_quit_btn.onClick.AddListener (delegate {
					custom_general.SetActive(true);
				});
				timer_alarm_ok_btn.onClick.AddListener (delegate {
					custom_general.SetActive(true);
				});
				break;
			}
			everything_Is_Setup = true;
		}
	}

	public bool everything_Is_Setup {
		get { 
			return this.everythingIsSetup;
		}
		set { 
			everythingIsSetup = value;
		}
	}*/

	/*void OnEnable(){
		SceneManager.sceneLoaded += OnLevelFinishedLoading;
	}
	void OnDisable(){
		SceneManager.sceneLoaded -= OnLevelFinishedLoading;
	}
	public void HidePanelMissions(int flag){
		PanelMissions.gameObject.GetComponent<CanvasGroup> ().alpha = flag;
	}

	private void OnLevelFinishedLoading(Scene scene,LoadSceneMode mode){
		Debug.Log ("LEVEL LOADED " + scene.name + " " + mode);
		switch(scene.name){
		case Scenes.GUEST_ROOM_SCENE:

			canvas = GameObject.FindGameObjectWithTag (Tags.CANVAS).GetComponent<Canvas> ();
			//Debug.Log ("NUMBER OF CHILD ELEMENTS INSIDE CANVAS " + canvas.transform.childCount);
			//for (int i = 0; i < canvas.transform.childCount; i++) {
			//	canvas.transform.GetChild (i).SetParent (generalCanvas.transform);
			//}
			//Camera camera = Camera.main;
			//generalCanvas.worldCamera = camera;
			HidePanelMissions (0);

			break;
		case Scenes.MAIN_MENU_SCENE:
			
			//generalCanvas.worldCamera = Camera.main;
			break;
		default:
			//HidePanelMissions(1);
			break;
		}

	}
*/
}
