using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System;

public class CustomAlertView : AlertView {

	public Text Title;
	public Text Message;
	public GameObject Button1;
	public GameObject Button2;
	public GameObject Input_Field;

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
			Button1.SetActive(true);
			Button1.GetComponentInChildren<Text>().text = (string)args["button1title"];
		}else {
			Button1.SetActive(false);
		}

		if(args.Contains("button2title")) {
			Button2.SetActive(true);
			Button2.GetComponentInChildren<Text>().text = (string)args["button2title"];
		}else {
			Button2.SetActive(false);
		}

		if(args.Contains("inputfieldactive")) {

			if((bool)args["inputfieldactive"]){

				Input_Field.SetActive(true);
				Input_Field.GetComponent<InputField> ().placeholder.GetComponent<Text>().text = "";

				if(args.Contains("inputfieldcontenttype")) {
					Input_Field.GetComponent<InputField> ().contentType = (InputField.ContentType)args["inputfieldcontenttype"];
				}

				if(args.Contains("inputfieldplaceholdertext")) {
					Input_Field.GetComponent<InputField> ().placeholder.GetComponent<Text>().text = (string)args["inputfieldplaceholdertext"];
				}
			}

		} else {
			Input_Field.SetActive(false);
		}
	}

	public void OnClick_Button1 () {
		
		background.GetComponent<PopupScaleManager>().OnCloseAnimationPlay(target, (string)args["button1callback"] , "");
	}

	public void OnClick_Button2 () {
		
		background.GetComponent<PopupScaleManager>().OnCloseAnimationPlay(target, (string)args["button2callback"] , Input_Field.GetComponent<UnityEngine.UI.InputField>().text );
	}
}
