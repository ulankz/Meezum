using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchDayNight : MonoBehaviour {

	public List<GameObject> dayItems;
	public List<GameObject> nightItems;
	public GameObject celestialBody;
	public GameObject helper;

	void OnMouseUpAsButton() {
		if (gameObject.name.ToLower ().Equals ("sun")) {
			ChangeDayNight (true);
		} else {
			ChangeDayNight (false);
		}

		if (helper) {
			helper.SetActive (false);
		}

	}

	void ChangeDayNight(bool swithTheDayOff) {
		gameObject.SetActive (false);
		celestialBody.SetActive (true);

		foreach (GameObject item in dayItems) {
			item.SetActive (!swithTheDayOff);
		}

		foreach (GameObject item in nightItems) {
			item.SetActive (swithTheDayOff);
		}
	}
}
