<<<<<<< HEAD
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDayTime : MonoBehaviour {

	public GameObject bg_day;
	public GameObject main_tree_day;
	public GameObject bg_night;
	public GameObject main_tree_night;

	public Vector2 dayTimeSpan;

	private enum dayNight {Day, Night};

	System.TimeSpan minTime;
	System.TimeSpan maxTime;
	int index;


	void checkDayTime() {
		if (System.DateTime.Now.TimeOfDay > minTime && System.DateTime.Now.TimeOfDay < maxTime) {
			bg_day.SetActive (true);
			main_tree_day.SetActive (true);
			bg_night.SetActive (false);
			main_tree_night.SetActive (false);
		} else {
			bg_day.SetActive (false);
			main_tree_day.SetActive (false);
			bg_night.SetActive (true);
			main_tree_night.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
		minTime = new System.TimeSpan((int)dayTimeSpan[0], 0, 0);
		maxTime = new System.TimeSpan((int)dayTimeSpan[1], 0, 0);

		checkDayTime();
	}
}
=======
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CheckDayTime : MonoBehaviour {

	public GameObject bg_day;
	public GameObject main_tree_day;
	public GameObject bg_night;
	public GameObject main_tree_night;

	public Vector2 dayTimeSpan;

	private enum dayNight {Day, Night};

	System.TimeSpan minTime;
	System.TimeSpan maxTime;
	int index;


	void checkDayTime() {
		if (System.DateTime.Now.TimeOfDay > minTime && System.DateTime.Now.TimeOfDay < maxTime) {
			bg_day.SetActive (true);
			main_tree_day.SetActive (true);
			bg_night.SetActive (false);
			main_tree_night.SetActive (false);
		} else {
			bg_day.SetActive (false);
			main_tree_day.SetActive (false);
			bg_night.SetActive (true);
			main_tree_night.SetActive (true);
		}
	}

	// Use this for initialization
	void Start () {
		minTime = new System.TimeSpan((int)dayTimeSpan[0], 0, 0);
		maxTime = new System.TimeSpan((int)dayTimeSpan[1], 0, 0);

		checkDayTime();
	}
}
>>>>>>> 33f2cedb6cfa0adb32d32431cbac6013b84ceafd
