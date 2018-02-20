using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class SimpleAlertView : AlertView {

	public Text Title;
	public Text Message;
	public GameObject Button1;

	public GameObject background;

	private GameObject target;
	private Hashtable args;

	void OnEnable () {
		background.transform.localScale = Vector3.zero;
	}

	// Use this for initialization
	void Start () {
		background.GetComponent<PopupScaleManager>().OnOpenAnimationPlay ();
	}

	public override void ShowAlertView (GameObject _target, Hashtable _args) {
		
		target = _target;
		args = _args;

		if(args.Contains("title")) {
			Title.text = (string)args["title"];
		}

		if(args.Contains("message")) {
			Message.text = (string)args["message"];
		}

		if(args.Contains("button1title")) {
			Button1.GetComponentInChildren<Text>().text = (string)args["button1title"];
		}
	}

	public void OnClick_Button1 () {

		background.GetComponent<PopupScaleManager>().OnCloseAnimationPlay(target, (string)args["button1callback"] , "");
	}
}
