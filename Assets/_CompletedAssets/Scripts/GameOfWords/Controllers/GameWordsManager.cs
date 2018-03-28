
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Array = System.Array;
using MeezumGame;

namespace GameOfWords
{
	public class GameWordsManager : MonoBehaviour
	{
	
	#region PRIVATE MEMBERS
		[SerializeField]
		private bool
			draggingItem = false;
		[SerializeField]
		private GameObject
			draggedObject;
		[SerializeField]
		private Vector2
			touchOffset;
		[SerializeField]
		private int
			numberOfLetters = 26;
		private Complexity levelComplexity;
		[SerializeField]
		private GameState
			gameState;
		private const int maxAttempts = 3;
		private int numberAttempts;
		[SerializeField]
		private Word[]
			words = new Word[10];
		[SerializeField]
		private string
			word;
		[SerializeField]
		private Vector2
			startPos;
		[SerializeField]
		private Transform
			question;
		[SerializeField]
		private int
			missionID = 0;
		[SerializeField]
		private Sprite[]
			sprites;
		[SerializeField]
		private GameObject[]
			cells;
		[SerializeField]
		private string
			userInput = "";
		private string answer;
		[SerializeField]
		private float
			letterPosOffset = 1.4f;
		[SerializeField]
		private const string
			letterPrefabPath = "Assets/_CompletedAssets/Prefabs/GameOfWords/LetterPrefab.prefab";
		[SerializeField]
		private const string
			spriteLoadPath = "GameOfWords/Alphabets";

	#endregion
	#region DELEGATES AND EVENTS
		public delegate void OnLevelComplexityChangeDelegate (Complexity levelCom);
		public event OnLevelComplexityChangeDelegate OnLevelComplexityChange;
	#endregion
	#region PUBLIC PROPERTIES
		[ExposeProperty]
		public Complexity LevelComplexity {
			get { 
				return levelComplexity;
			}
			set { 
				if (levelComplexity != value) {
					levelComplexity = value;
					if (OnLevelComplexityChange != null)
						OnLevelComplexityChange (levelComplexity);
				}
			}
		}
		[ExposeProperty]
		Vector2 CurrentTouchPosition {
			get {
				Vector2 inputPos;
				inputPos = Camera.main.ScreenToWorldPoint (Input.mousePosition);
				return inputPos;
			}
		}
		[ExposeProperty]
		private bool HasInput {
			get {
				// returns true if either the mouse button is down or at least one touch is felt on the screen
				return Input.GetMouseButton (0);
			}
		}
	#endregion
	#region SYSTEM METHODS
		void Awake ()
		{
			GenerateWords ();
		}
		void Start ()
		{
			using (var bench = new Benchmark ("Code runs in :")) {
				gameState = GameState.STARTED;
				ReferSceneObjects ();
				//DeactivateCells ();
				OnLevelComplexityChange += OnLevelComplexityChangeHandler;
				LevelComplexity = Complexity.Two;
				//populateLettersArray ();
				sprites = LoadSprites ();
				CreateLettersForWord (missionID);
				//GenerateCells (LevelComplexity);
			}
		}
		void Update ()
		{
			if (HasInput) {
				DragOrPickUp ();
			} else {
				if (draggingItem)
					DropItem ();
			}
		}
		void Destroy ()
		{
			OnLevelComplexityChange -= OnLevelComplexityChangeHandler;
		}
	#endregion
	#region PUBLIC METHODS
		public void CheckAnswer ()
		{
			// Logic for checking answer
			userInput = GetInputFromUser ();
			string[] temp;
			int ansIndex = 0;
			if (!userInput.Contains (" ") && words [missionID].AnswersDict.TryGetValue ((int)LevelComplexity, out temp)) {
				ansIndex = Array.BinarySearch (temp, userInput);
			}
			if (ansIndex > 0) {
				Debug.Log ("ANSWER IS CORRECT -> " + ansIndex);	

			} else {
				Debug.Log ("ANSWER IS WRONG -> " + ansIndex);	
			}
		}
	#endregion
	#region PRIVATE METHODS
		private void GenerateCells (Complexity lComplexity)
		{
			// Cells depend on level of complexity
			DeactivateCells ();
			for (int i = 0; i < (int)lComplexity; i++) {
				cells [i].SetActive (true);
			}
		}
		private void GivePoints ()
		{
			// Logic for adding points and showing them in UI
		}
		private void ActionAlert ()
		{
			// Should allert after every 8 seconds in case of no action
		}
		private void CreateLettersForWord (int missionId)
		{
			//Logic for creating letters
			word = words [missionId].Description;
			string[] characters = word.ToCharArray ().Select (c => c.ToString ()).ToArray ();
			GameObject letter = null;
			string letterName = null;
			for (int i = 0; i < characters.Length; i++) {
				letter = CreateLetter ();
				letter.transform.SetParent (question);
				letterName = characters [i].ToString ();
				letter.GetComponent<SpriteRenderer> ().sprite = GetSpriteByName (letterName);
				letter.transform.localPosition = new Vector2 (startPos.x + letterPosOffset, startPos.y); 	
				letter.transform.name = letterName;
				letter.transform.localScale = Vector2.one;
				startPos = letter.transform.localPosition;
			}
		}

		private void  DeactivateCells ()
		{
			if (cells != null)
				foreach (GameObject g in cells) {
					if (g.activeSelf)
						g.SetActive (false);
				}
		}
		private string GetInputFromUser ()
		{
			string result = "";
			if (cells != null)
				foreach (GameObject g in cells) {
					if (g.activeSelf && g.transform.childCount > 0)
						result += g.transform.GetChild (0).name;	
				}
			Debug.Log ("INPUT FROM USER IS " + result);
			return result;
		}

//	private void PopulateLettersArray(){
//		lettersGO = new Transform[numberOfLetters];
//		Transform letters = GameObject.FindGameObjectWithTag ("Letters").transform;
//
//		if (letters != null)
//			for (int i = 0; i < 26; i++) {
//				lettersGO [i] = letters.GetChild (i).transform;
//			}
//		else {
//			Debug.LogError ("LETTERS objects in null");
//			return;
//		}
//	}
		private void ReferSceneObjects ()
		{
			question = GameObject.FindGameObjectWithTag (Tags.QUESTION).transform;
			cells = GameObject.FindGameObjectsWithTag (Tags.CELL).OrderBy (g => g.name).ToArray ();
		}
		private GameObject CreateLetter ()
		{
			Object letterPrefab = AssetDatabase.LoadAssetAtPath (letterPrefabPath, typeof(GameObject));
			GameObject letter = Instantiate (letterPrefab, Vector2.zero, Quaternion.identity) as GameObject;
			letter.transform.localPosition = Vector2.zero;
			if (letter)
				return letter;
			return null;
		}
		private Sprite[] LoadSprites ()
		{
			var sprites = Resources.LoadAll<Sprite> (spriteLoadPath);
			if (sprites.Length > 0) {
				Debug.Log ("SPRITE LOADING COMPLETED SUCCESSFULLY");
				return sprites;
			}
			return null;
		}
		private Sprite GetSpriteByName (string name)
		{
			Sprite result = null;
			foreach (Sprite s in sprites) {
				if (s.name.Equals ("letter_" + name))
					result = s;
			}
			return result;
		}
		private void GenerateWords ()
		{
			string[] three = new string[12]{ "TAM", "PUK", "UPS", "SUP", "CAM", "CET", "RAK", "MAK", "KUM", "SUK", "TUP", "PAT" };
			Array.Sort (three);
			string[] four = new string[21] {
			"KURT",
			"KURS",
			"KRUP",
			"UTES",
			"MERA",
			"TEMA",
			"TRAP",
			"STUK",
			"SERP",
			"UTKA",
			"REPS",
			"REPA",
			"RUKA",
			"REKA",
			"PUMA",
			"PARK",
			"MARS",
			"STUK",
			"SKAT",
			"SERA",
			"KREP"
		};
			Array.Sort (four);
			string[] five = new string[12] {
			"TRESK",
			"TURKA",
			"TERMA",
			"SPRUT",
			"TESAK",
			"TRESk",
			"MAKET",
			"SUPER",
			"SUMKA",
			"SEKTA",
			"METKA",
			"REPKA"
		};
			Array.Sort (five);
			string[] six = new string[8]{ "PARKET", "SEKRET", "STUPKA", "KAPERS", "MARKET", "TRESKA", "MARKER", "STERKA" };
			Array.Sort (six);
			Dictionary<int,string[]> temp = new Dictionary<int, string[]> ();
			temp.Add (3, three);
			temp.Add (4, four);
			temp.Add (5, five);
			temp.Add (6, six);
			words [0] = new Word (){ Description = "SUPERMARKET", AnswersDict = temp};
			Debug.Log ("WORDS GENERATED SUCCESSFULLY");
		}
		// EVENT HANDLERS
		private void OnLevelComplexityChangeHandler (Complexity levelComplexity)
		{
			GenerateCells (levelComplexity);
			//Debug.Log ("OnLevelComplexityChangeHandler IS CALLED " + (int)levelComplexity);
		}
		private void DragOrPickUp ()
		{
			var inputPosition = CurrentTouchPosition;
			
			if (draggingItem) {
				draggedObject.transform.position = inputPosition + touchOffset;
			} else {
				RaycastHit2D[] touches = Physics2D.RaycastAll (inputPosition, inputPosition, 0.5f);
				if (touches.Length > 0) {
					var hit = touches [0];
					if (hit.transform != null && hit.transform.tag == Tags.TILE) {
						draggingItem = true;
						draggedObject = hit.transform.gameObject;
						touchOffset = (Vector2)hit.transform.position - inputPosition;
						//draggedObject.transform.localScale = new Vector3(1.2f,1.2f,1.2f);
						hit.transform.GetComponent<Tile> ().PickUp ();
					}
				}
			}
		}

		private void DropItem ()
		{
			draggingItem = false;
			//draggedObject.transform.localScale = new Vector3(1f,1f,1f);
			draggedObject.GetComponent<Tile> ().Drop ();
		}
	#endregion
	}
}
