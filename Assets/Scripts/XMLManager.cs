using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;

public class XMLManager : MonoBehaviour {
	public static XMLManager ins;
	public PlayerDatabase playerDB;
	private string  path;
	void Awake() {
		ins = this;
		path = getPath ("player_data.xml");
		Debug.Log ("Persistent data path is " + path);
			LoadPlayers ();

	/*if (Application.platform == RuntimePlatform.IPhonePlayer ) {//|| Application.platform == RuntimePlatform.Android
			/*path = Application.persistentDataPath + "/player_data.xml";
			if (File.Exists (path)) {
				LoadPlayers ();
			} else {
				path = Application.dataPath + "/Resources/" + "player_data.xml";
				LoadPlayers ();
				path = Application.persistentDataPath + "/player_data.xml";
				if (!File.Exists (path)) {
					FileStream file = File.Create (path);	
					Debug.Log ("File Created " + path);
					XmlSerializer serializer = new XmlSerializer (typeof(PlayerDatabase));
					//var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
					serializer.Serialize (file, playerDB);
					file.Close ();
				} 
			}				
		*/
	//}
	/*	else if (Application.platform == RuntimePlatform.Android) {
			//path = Application.persistentDataPath + "/player_data.xml";

			if (File.Exists (path)) {
				LoadPlayers ();
			} else {
			/*
				path = Application.dataPath + "/Resources/" + "player_data.xml";
				LoadPlayers ();
				path = Application.persistentDataPath + "/player_data.xml";
				if (!File.Exists (path)) {
					FileStream file = File.Create (path);	
					Debug.Log ("File Created " + path);
					XmlSerializer serializer = new XmlSerializer (typeof(PlayerDatabase));
					//var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
					serializer.Serialize (file, playerDB);
					file.Close ();
				} 
		*/
//		}				
//		}

	/*	else if (Application.platform == RuntimePlatform.WindowsEditor) {
			//path = Application.dataPath + "/Resources/" + "player_data.xml";
			LoadPlayers ();
			//Debug.Log ("Application path editor " + path);
		} else {
			//path = Application.dataPath + "/Resources/player_data.xml";
			LoadPlayers ();
			//Debug.Log ("Application1 path editor " + path);
	}*/	
	}

	public void SavePlayers() {
		XmlSerializer serializer = new XmlSerializer (typeof(PlayerDatabase));
		var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
		StreamWriter stream = new StreamWriter (path, false, encoding);
		serializer.Serialize (stream, playerDB);
		stream.Close ();
	}
	public void LoadPlayers() {
		XmlSerializer serializer = new XmlSerializer (typeof(PlayerDatabase));
		StreamReader stream = new StreamReader (path);
		playerDB = serializer.Deserialize (stream) as PlayerDatabase;
		stream.Close ();
	}
	void OnApplicationPause() {
		SavePlayers ();
	}
	void OnApplicationFocus() {
		SavePlayers ();
	}
	void OnApplicationQuit() {
		SavePlayers ();
	}
	private string getPath(string fileName){
		#if UNITY_EDITOR
		return Application.dataPath +"/Resources/"+fileName;
		#elif UNITY_ANDROID
		return Application.persistentDataPath+fileName;
		#elif UNITY_IPHONE
		return Application.persistentDataPath+"/"+fileName;
		#else
		return Application.dataPath +"/"+ fileName;
		#endif
		}
	}

[System.Serializable]
public class PlayerEntry {
	public string playerName;
	public int age;
	public int scores;
	public int cookies;
	public int eatenCookies;
	public int boughtCookies;
	public int cleanedMessItems;
	public List<MessItem> messItems;
}
[System.Serializable]
public class PlayerDatabase {
	[XmlArray("Players")]
	public List<PlayerEntry> list = new List<PlayerEntry> ();
}
//public enum MessItemStatus {Queued, Disclosed, Cleaned};

[System.Serializable]
public class MessItem {
	public string messItemName;
//	public MessItemStatus status;
}
