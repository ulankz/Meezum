using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
namespace Localization{
public class LocalizationManager : MonoBehaviour {
	
	public static LocalizationManager instance;
	
	private Dictionary<string, string> localizedText;
	private bool isReady = false;
	private string missingTextString = "Localized text not found";
	
	// Use this for initialization
	void Awake () 
	{
		if (instance == null) {
			instance = this;
		} else if (instance != this)
		{
			Destroy (gameObject);
		}
		
		DontDestroyOnLoad (gameObject);
	}

	void Start() {
		LoadLocalizedText("localizedUI_ru.json");
	}
	
	public void LoadLocalizedText(string fileName)
	{
		localizedText = new Dictionary<string, string> ();
		string filePath = Path.Combine (Application.streamingAssetsPath, fileName);
		
			string dataAsJson;
			if(Application.platform == RuntimePlatform.Android) //Need to extract file from apk first
			{
				WWW reader = new WWW(filePath);
				while (!reader.isDone) { }

				dataAsJson= reader.text;
			}
			else
			{
				dataAsJson= File.ReadAllText(filePath);
			}

		

			LocalizationData loadedData = JsonUtility.FromJson<LocalizationData> (dataAsJson);
			
			for (int i = 0; i < loadedData.items.Length; i++) 
			{
				localizedText.Add (loadedData.items [i].key, loadedData.items [i].value);   
			}
			
			Debug.Log ("Data loaded, dictionary contains: " + localizedText.Count + " entries");
		
		
		isReady = true;
	}
	
	public string GetLocalizedValue(string key)
	{
		string result = missingTextString;
		if (localizedText.ContainsKey (key)) 
		{
			result = localizedText [key];
		}
		
		return result;
		
	}
	
	public bool GetIsReady()
	{
		return isReady;
	}
	
	}}