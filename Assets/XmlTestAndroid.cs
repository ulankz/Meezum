using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
public class XmlTestAndroid : MonoBehaviour {
	
	// Update is called once per frame
	[SerializeField]
	private int command;
	void Update () {
		if (command == 0)
			GetComponent<Text> ().text = System.IO.File.Exists (GlobalGameManager.instance.playerManager.getPath ()).ToString ();
		else {
			GetComponent<Text> ().text = GlobalGameManager.instance.playerManager.getPath ();
		}
	}

}
