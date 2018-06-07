using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;
using UnityEngine.SceneManagement;
using MeezumGame;

public class GameDurationTimerManager : MonoBehaviour
{
	private double timer;
	private bool timerIsLaunched = false;
	private bool appIsTerminated = false;
	private int alertFontSize = 30;

	// Update is called once per frame
	void Update () {
		if (timerIsLaunched) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				if (appIsTerminated) {
					Application.Quit ();
				} else {
					PopUpNotification ();
				}
			}
		}
	}

	public void SetExpirationTime(Text minutes) {
		try {
			timer = Convert.ToDouble(minutes.text);
			if(timer == 30) {
				timer = 1800; // 30m = 1800s
			} else if (timer == 45) {
				timer = 2700; // 45m = 2700s
			} else if (timer == 60) {
				timer = 3600; // 60m = 3600s
			}
		}
		catch (FormatException) {
			Debug.Log("Unable to convert " + minutes.text + " to a Double.");
		}               
		catch (OverflowException) {
			Debug.Log(minutes.text + " is outside the range of a Double.");
		}
	}

	public void StartTimer() {
		if (timer != 0) {
			timerIsLaunched = true;
		}
	}

	public void PopUpNotification() {
		appIsTerminated = true;
		timer = 2;
		string sceneName = SceneManager.GetActiveScene ().name;
		GameObject canvas = null;
		switch (sceneName) {
			case "Forest":
				alertFontSize = 30;
				canvas = GameObject.Find ("CanvasGeneralUI");
				break;
			case "Comics":
				alertFontSize = 65;
				canvas = GameObject.Find ("Canvas");
				//canvas = GameObject.Find ("CanvasGeneralUI");
				break;
			case "Maze":
				alertFontSize = 24;
				canvas = GameObject.Find ("Canvas");
				break;
		}
		GameObject appTerminationNotificationPanel = new GameObject ("App Termination Notification");
		appTerminationNotificationPanel.AddComponent<CanvasRenderer> ();
		appTerminationNotificationPanel.AddComponent<RectTransform> ();
		Vector2 canvasSize = canvas.GetComponent<RectTransform> ().sizeDelta;
		appTerminationNotificationPanel.GetComponent<RectTransform> ().sizeDelta = canvasSize;
		Image appTerminationNotificationPanelBG = appTerminationNotificationPanel.AddComponent<Image> ();
		appTerminationNotificationPanelBG.color = new Color ((float)1.0, (float)1.0, (float)1.0, (float)100/255);
		GameObject Message = new GameObject ("Message");
		Message.AddComponent<RectTransform> ();
		Message.GetComponent<RectTransform> ().sizeDelta = new Vector2 (canvasSize.x, canvasSize.y/2);
		Text message = Message.AddComponent<Text> ();
		Message.layer = 5;
		Message.transform.SetParent (appTerminationNotificationPanel.transform, false);
		message.text = "Игра закроется, так как заданное Вами время истекло!";
		message.font = Resources.GetBuiltinResource (typeof(Font), "Arial.ttf") as Font;
		message.fontSize = alertFontSize;
		message.color = Color.black;
		message.alignment = TextAnchor.MiddleCenter;
		appTerminationNotificationPanel.transform.SetParent (canvas.transform, false);
	}
}

