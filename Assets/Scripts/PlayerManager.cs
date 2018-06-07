using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
namespace OLD{
public class PlayerManager : MonoBehaviour {
	//public static XMLManager ins;
	public PlayerDB playerDB;
	private string  path;

	void Awake() {
		//ins = this;
		Debug.Log ("Persistent data path is " + Application.persistentDataPath);
		if (Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.Android) {
			path = Application.persistentDataPath + "/player_data.xml";
			if (File.Exists (path)) {
				LoadPlayers ();
			} else {
				path = Application.dataPath + "/Resources/" + "player_data.xml";
				LoadPlayers ();
				path = Application.persistentDataPath + "/player_data.xml";
				if (!File.Exists (path)) {
					FileStream file = File.Create (path);	
					Debug.Log ("File Created " + path);
					XmlSerializer serializer = new XmlSerializer (typeof(PlayerDB));
					//var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
					serializer.Serialize (file, playerDB);
					file.Close ();
				} 
			}				
		} 
		/*else if (Application.platform == RuntimePlatform.WindowsEditor) {
			path = Application.dataPath + "/Resources/" + "player_data.xml";
			LoadPlayers ();
			//Debug.Log ("Application path editor " + path);
		}*/
		else {
			path = Application.dataPath + "/Resources/player_data.xml";
			LoadPlayers ();
			//Debug.Log ("Application1 path editor " + path);
		}
	}

	public void SavePlayers() {
		XmlSerializer serializer = new XmlSerializer (typeof(PlayerDB));
		var encoding = System.Text.Encoding.GetEncoding ("UTF-8");
		StreamWriter stream = new StreamWriter (path, false, encoding);
		serializer.Serialize (stream, playerDB);
		stream.Close ();
	}

	public void LoadPlayers() {
		XmlSerializer serializer = new XmlSerializer (typeof(PlayerDB));
		StreamReader stream = new StreamReader (path);
		playerDB = serializer.Deserialize (stream) as PlayerDB;
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
}

[System.Serializable]
public class Player {
	public string playerName;
	public int scores;
}

[System.Serializable]
public class PlayerDB {
	[XmlArray("Players")]
	public List<Player> list = new List<Player> ();
}
}
