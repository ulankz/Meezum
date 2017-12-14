﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
enum Complexity {
	One = 3,
	Two = 3,
	Three = 4,
	Four = 5,
	Five = 6
};
enum GameState{
	DEFAULT,
	STARTED,
	WON,
	FAILED,
	FINISHED
};
[System.Serializable]
  struct Word{
	   private string description;
	   private Dictionary<int,string[]> answersDict;
	public string Description{
		set{
			description = value;	
		}
		get{
			return description;
		}
	}
	public Dictionary<int,string[]> AnswersDict{
		set{ 
			answersDict = value;
		}
		get{ 
			return answersDict;
		}
	}
	public Word(string d, Dictionary<int,string[]> ans){
		description = d;
		answersDict = ans;
	}
}
public class GameWordsManager : MonoBehaviour {
	
	//Public members

	//Private members


	[SerializeField]
	private int numberOfLetters = 26;
	private Complexity levelComplexity;
	private GameState gameState;
	private const int maxAttempts = 3;
	private int numberAttempts;
	//[SerializeField]
	private Word[] words = new Word[10];
	[SerializeField]
	private Transform[] lettersGO;
	[SerializeField]
	private string word;
	[SerializeField]
	private Vector2 startPos;
	[SerializeField]
	private Transform question;
	[SerializeField]
	private int missionID = 0;
	[SerializeField]
	private Sprite[] sprites;
	void Awake(){
		GenerateWords ();
	}
	void Start () {
		levelComplexity = Complexity.One;
		gameState = GameState.STARTED;
		ReferSceneObjects ();
		//populateLettersArray ();
		sprites = LoadSprites();
		CreateLettersForWord (missionID);
		CreateCells ();
	}
	private void CreateCells(){
		//Logic for cell creation
	}
	public void CheckAnswer(){
		// Logic for checking answer
	}
	private void GivePoints(){
		// Logic for adding points and showing them in UI
	}
	private void ActionAlert(){
		// Should allert after every 8 seconds in case of no action
	}
	private void CreateLettersForWord(int missionId){
		//Logic for creating letters
		word = words[missionId].Description;
		string[] characters = word.ToCharArray ().Select (c => c.ToString ()).ToArray ();
		GameObject letter = null;
		string letterName = null;
		for (int i = 0; i < characters.Length; i++) {
			letter = CreateLetter ();
			letter.transform.parent = question;
			letterName = characters [i].ToString ();
			letter.GetComponent<SpriteRenderer> ().sprite = GetSpriteByName (letterName);
			letter.transform.localPosition = new Vector2 (startPos.x + 1.5f, startPos.y); 

			letter.transform.name = letterName;

			startPos = letter.transform.localPosition;
		}
	}
	private void PopulateLettersArray(){
		lettersGO = new Transform[numberOfLetters];
		Transform letters = GameObject.FindGameObjectWithTag ("Letters").transform;

		if (letters != null)
			for (int i = 0; i < 26; i++) {
				lettersGO [i] = letters.GetChild (i).transform;
			}
		else {
			Debug.LogError ("LETTERS objects in null");
			return;
		}
	}
	private void ReferSceneObjects(){
		question = GameObject.FindGameObjectWithTag ("Question").transform;
	}
	private GameObject CreateLetter(){
		Object letterPrefab = AssetDatabase.LoadAssetAtPath("Assets/Prefabs/GameOfWords/LetterPrefab.prefab", typeof(GameObject));
		GameObject letter = Instantiate (letterPrefab,Vector2.zero,Quaternion.identity) as GameObject;
		letter.transform.localPosition = Vector2.zero;
		if (letter)
			return letter;
		return null;
	}
	private Sprite[] LoadSprites(){
		var sprites = Resources.LoadAll<Sprite>("GameOfWords/Alphabets");
		if (sprites.Length > 0) {
			Debug.Log ("SPRITE LOADING COMPLETED SUCCESSFULLY");
			return sprites;
		}
		return null;
	}
	private Sprite GetSpriteByName(string name){
		Sprite result = null;
		foreach (Sprite s in sprites) {
			if (s.name.Equals ("letter_"+name))
				result = s;
			
		}
		return result;
	}
	private void GenerateWords(){
		Dictionary<int,string[]> temp = new Dictionary<int, string[]> ();
		temp.Add(3,new string[12]{"TAM","PUK","UPS","SUP","CAM","CET","RAK","MAK","KUM","SUK","TUP","PAT"});
		temp.Add(4,new string[21]{"KURT","KURS","KRUP","UTES","MERA","TEMA","TRAP","STUK","SERP","UTKA","REPS","REPA","RUKA","REKA","PUMA","PARK","MARS","STUK","SKAT","SERA","KREP"});
		temp.Add(5,new string[12]{"TRESK","TURKA","TERMA","SPRUT","TESAK","TRESk","MAKET","SUPER","SUMKA","SEKTA","METKA","REPKA"});
		temp.Add(6,new string[8]{"PARKET","SEKRET","STUPKA","KAPERS","MARKET","TRESKA","MARKER","STERKA"});
		words [0] = new Word (){ Description = "SUPERMARKET", AnswersDict = temp};
		Debug.Log ("WORDS GENERATED SUCCESSFULLY");
	}
}
