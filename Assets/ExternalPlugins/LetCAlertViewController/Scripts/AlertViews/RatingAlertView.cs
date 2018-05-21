using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RatingAlertView : AlertView {

	public Sprite blankHeart;
	public Sprite filledHeart;

	public Image[] heartsImage;

	public Text Title;
	public Text Message;
	public GameObject Button1;
	public GameObject Button2;

	public GameObject background;

	private GameObject target;
	private Hashtable args;

	private int rating;

	void OnEnable () {
		background.transform.localScale = Vector3.zero;
	}

	// Use this for initialization
	void Start () {
		background.GetComponent<PopupScaleManager>().OnOpenAnimationPlay ();
		for(int i = 0; i < heartsImage.Length; i++) {
			heartsImage[i].sprite = blankHeart;
		}
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


	}

	public void OnClick_Button1 () {

		background.GetComponent<PopupScaleManager>().OnCloseAnimationPlay(target, (string)args["button1callback"] , "");
	}

	public void OnClick_Button2 () {

		background.GetComponent<PopupScaleManager>().OnCloseAnimationPlay(target, (string)args["button2callback"] , rating.ToString() );
	}

	public void OnClick_RatingButton (int value) {

		rating = value;

		int remainingIndex = 0;
		for(int i = 0; i < value; i++) {
			heartsImage[i].sprite = filledHeart;
			remainingIndex = i+1;
		}

		while(remainingIndex < heartsImage.Length) {
			heartsImage[remainingIndex].sprite = blankHeart;
			remainingIndex++;
		}
	}
}
