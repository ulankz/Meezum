using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;

public class Notification : MonoBehaviour {

	public double timer;
	public bool timerIsLaunched;

	private ModalPanel modalPanel;

	private UnityAction myOkAction;
	private UnityAction myCancelAction;

	void Start() {
		timer = 2.0;
		timerIsLaunched = false;
	}

	// Update is called once per frame
	void Update () {
		if (timerIsLaunched) {
			timer -= Time.deltaTime;
			if (timer <= 0) {
				timer = 2.0;
				PopUpNotification();
				timerIsLaunched = false;
			}
		}
	}

	public void StartTimer() {
		timerIsLaunched = true;
	}

	public void PopUpNotification() {
		modalPanel = ModalPanel.Instance ();

		myOkAction = new UnityAction (TestOkFunction);
		myCancelAction = new UnityAction (TestCancelFunction);

		TestOptions ();
	}

	public void TestOptions() {
		modalPanel.Option("The pop up message is displayed!", myOkAction, myCancelAction);
	}

	void TestOkFunction() {
		Debug.Log ("Ok!");
	}

	void TestCancelFunction() {
		Debug.Log ("Canceled");
	}
}
