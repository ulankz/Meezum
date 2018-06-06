﻿using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using System;

public class GameDurationTimerManager : MonoBehaviour
{
	private double timer;
	private bool timerIsLaunched = false;

	// Update is called once per frame
	void Update () {
		if (timerIsLaunched) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				Application.Quit ();
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
}

