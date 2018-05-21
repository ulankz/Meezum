using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SampleMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void OnClick_SimpleAlert () {
		UIAlertView.instance.ShowSimpleAlertView(gameObject,
			UIAlertView.Hash(
				"title","Title",
				"message","Hello world",
				"button1title","OK",
				"button1callback","SimpleAlertCallback")
		);
	}

	public void OnClick_SimpleAlertStory () {
		UIAlertView.instance.ShowSimpleAlertView(gameObject,
			UIAlertView.Hash(
				"title","Story",
				"message","I trapped the spider in a glass tumbler, the likes of which severed one of its legs, creating a grossly disfigured monster. But I look through the glass and see: the true monster is me.",
				"button1title","OK",
				"button1callback","SimpleAlertStoryCallback")
		);
	}

	public void OnClick_SimpleCustomAlert () {
		UIAlertView.instance.ShowCustomAlertView(gameObject,
			UIAlertView.Hash(
				"title","Alert",
				"message","Are you sure you want to delete this image?",
				"button1title","Cancel",
				"button1callback","SimpleCustomAlertButton1Callback",
				"button2title","Yes",
				"button2callback","SimpleCustomAlertButton2Callback",
				"inputfieldplaceholdertext","password")
		);
	}

	public void OnClick_CustomAlertEmail () {
		UIAlertView.instance.ShowCustomAlertView(gameObject,
			UIAlertView.Hash(
				"title","Email",
				"message","Please enter your email",
				"button1title","Cancel",
				"button2title","OK",
				"button2callback","CustomAlertEmailCallback",
				"inputfieldactive",true,
				"inputfieldcontenttype",InputField.ContentType.EmailAddress,
				"inputfieldplaceholdertext","email")
		);
	}

	public void OnClick_CustomAlertPassword () {
		UIAlertView.instance.ShowCustomAlertView(gameObject,
			UIAlertView.Hash(
				"title","Password",
				"message","Please enter your password",
				"button1title","Cancel",
				"button2title","OK",
				"button2callback","CustomAlertPasswordCallback",
				"inputfieldactive",true,
				"inputfieldcontenttype",InputField.ContentType.Password,
				"inputfieldplaceholdertext","password")
		);
	}

	public void OnClick_RatingAlert () {
		UIAlertView.instance.ShowRatingAlertView(gameObject,
			UIAlertView.Hash(
				"title","Rate us",
				"message","Please rate us based on your expeirence.",
				"button1title","Cancel",
				"button2title","OK",
				"button2callback","RatingAlertButton2Callback")
		);
	}

	public void SimpleAlertCallback () {
		Debug.Log("SimpleAlertCallback");
	}

	public void SimpleAlertStoryCallback () {
		Debug.Log("SimpleAlertStoryCallback");
	}

	public void CustomAlertEmailCallback (string data) {
		Debug.Log("CustomAlertEmailCallback "+data);
	}

	public void CustomAlertPasswordCallback (string data) {
		Debug.Log("CustomAlertPasswordCallback "+data);
	}

	public void SimpleCustomAlertButton1Callback () {
		Debug.Log("SimpleCustomAlertButton1Callback ");
	}

	public void SimpleCustomAlertButton2Callback () {
		Debug.Log("SimpleCustomAlertButton2Callback ");
	}

	public void RatingAlertButton1Callback () {
		Debug.Log("RatingAlertButton1Callback ");
	}

	public void RatingAlertButton2Callback (string data) {
		Debug.Log("RatingAlertButton2Callback "+data);
	}
}
