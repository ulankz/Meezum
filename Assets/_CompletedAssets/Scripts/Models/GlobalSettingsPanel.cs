using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using MeezumGame;
using UnityEngine.SceneManagement;

public class GlobalSettingsPanel : MonoBehaviour {

	public GameObject canvas;
	public GameObject globalSettingsPanel;
	public GameObject general;
	public GameObject custom_general;
	public GameObject settings_btn;
	public GameObject quit_btn;
	public GameObject store_btn;
	public Button timer_quit_btn;
	public Button timer_alarm_ok_btn;
	private bool everythingIsSetup = false;
	string sceneName = "", prevSceneName = "";

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

	public bool everything_Is_Setup {
		get { 
			return this.everythingIsSetup;
		}
		set { 
			everythingIsSetup = value;
		}
	}

	private void Awake() {
		if (instance != null) {
			Destroy (gameObject);
		} else {
			instance = this;
			DontDestroyOnLoad (gameObject);
		}
	}

	void Update() {
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
}
