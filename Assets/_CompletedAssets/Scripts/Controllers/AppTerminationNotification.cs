using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class AppTerminationNotification : MonoBehaviour {

	public Text message;
	public GameObject appTerminationNotificationObject;

	private static AppTerminationNotification appTerminationNotification;

	public static AppTerminationNotification Instance () {
		if (!appTerminationNotification) {
			appTerminationNotification = FindObjectOfType (typeof(AppTerminationNotification)) as AppTerminationNotification;
			if (!appTerminationNotification)
				Debug.LogError ("There needs to be one active AppTerminationNotification script on a GameObject in your scene.");
		}
		return appTerminationNotification;
	}

	public void Option(string message) {
		appTerminationNotificationObject.SetActive (true);
		this.message.text = message;
	}

	void ClosePanel () {
		appTerminationNotificationObject.SetActive (false);
	}
}
