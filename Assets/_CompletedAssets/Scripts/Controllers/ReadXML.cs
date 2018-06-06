using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;

public class ReadXML : MonoBehaviour {

	XDocument xmlDoc;
	IEnumerable<XElement> items;
	List <XMLData> data = new List <XMLData>();
	public string messItemName, status;

	// Use this for initialization
	void Start () {
		DontDestroyOnLoad (gameObject);
		LoadXML ();
		StartCoroutine (AssignData());
	}

	void LoadXML() {
		xmlDoc = XDocument.Load ("Assets/_CompletedAssets/Resources/XML Files/player_data.xml");
		items = xmlDoc.Descendants ("MessItem").Elements ();
	}

	IEnumerator AssignData() {
		foreach(XElement item in items) {
			messItemName = item.Parent.Element ("messItemName").Value.Trim ();
			status = item.Parent.Element ("status").Value.Trim ();
			data.Add (new XMLData (messItemName, status));
			Debug.Log(data[data.Count-1].messItemName);
		}
		yield return null;
	}
}

public class XMLData {

	public string messItemName, status;

	public XMLData(string messItemName, string status) {
		this.messItemName = messItemName;
		this.status = status;
	}
}
