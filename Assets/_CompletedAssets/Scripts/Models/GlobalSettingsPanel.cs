using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.UI;
using UnityEngine.Events;
using MeezumGame;
using UnityEngine.SceneManagement;

public class GlobalSettingsPanel : MonoBehaviour {

	public GameObject globalSettingsPanel;
	public GameObject general;
	public GameObject custom_general;
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
				custom_general.SetActive (false);
				timer_quit_btn.onClick.AddListener (delegate {
					general.SetActive(true);
				});
				timer_alarm_ok_btn.onClick.AddListener (delegate {
					general.SetActive(true);
				});
				break;
			case "Comics":
			case "Maze":
				general.SetActive (false);
				custom_general.SetActive (true);
				timer_quit_btn.onClick.AddListener (delegate {
					custom_general.SetActive(true);
				});
				timer_alarm_ok_btn.onClick.AddListener (delegate {
					custom_general.SetActive(true);
				});
				break;
			}
		}
	}
}
