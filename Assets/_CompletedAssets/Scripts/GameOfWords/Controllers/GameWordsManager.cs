using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEditor;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Array = System.Array;
using MeezumGame;
using UnityEngine.SceneManagement;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;

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
		private  int maxAttempts = 2;
		private int numberAttempts;
		[SerializeField]
		private int wordsCount = 3;
		private Word[] words;
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
			letterPrefabPath = "Assets/Resources/GameOfWords/GameOfWords/LetterPrefab.prefab";
		[SerializeField]
		private GameObject letterPrefab;
		[SerializeField]
		private const string
			spriteLoadPath = "GameOfWords/Alphabets";

		// UI Fields
		[SerializeField]
		private GameWordsUIManager
			gameWordsUIManager; 
		[SerializeField]
		private bool wordsGameStarted;
		[SerializeField]
		private InstructionSoundManager instructionSoundManager;
		[SerializeField]
		private SoundManager soundManager;
		[SerializeField]
		private IdleCheck notificationManager;
		[SerializeField]
		private int
			currentQuestionIndex = 0;
		private float nextQuestionDelay = 2f;
		private int maxQuestions = 5;
		private bool UIDisabled = false;
	#endregion
	#region DELEGATES AND EVENTS
		public delegate void OnLevelComplexityChangeDelegate (Complexity levelCom);
		public event OnLevelComplexityChangeDelegate OnLevelComplexityChange;
		public delegate void OnAnswerCheckedDelegate (bool answered);
		public event OnAnswerCheckedDelegate onAnswerChecked;
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
				// returns true if either the mouse button is down or at least one touch is left on the screen
				return Input.GetMouseButton (0)&&!UIDisabled;
			}
		}
	#endregion
	#region SYSTEM METHODS
		void Awake ()
		{
			gameWordsUIManager = GameObject.FindGameObjectWithTag (Tags.GAME_WORDS_UI_MANAGER).GetComponent<GameWordsUIManager> ();
			instructionSoundManager = GameObject.FindGameObjectWithTag (Tags.INSTRUCTIONS_SOUND_MANAGER).GetComponent<InstructionSoundManager> ();
			soundManager = GameObject.FindGameObjectWithTag (Tags.SOUND_MANAGER).GetComponent<SoundManager> ();
			notificationManager = GameObject.FindGameObjectWithTag (Tags.NOTIFICATION_MANAGER).GetComponent<IdleCheck> ();
			if (gameWordsUIManager == null)
				Debug.LogError ("QUIZ_UI_MANAGER IS NULL !!");
			GenerateWords ();
			if (words.Length == 0)
				Debug.LogError ("WORDS LIST IS EMPTY !!");
		}
		void Start ()
		{
			//using (var bench = new Benchmark ("Code runs in :")) {
			SetupGame ();
			StartGameWordsGame ();
				
			//}
		}
		void Update ()
		{
			if (HasInput) {
				DragOrPickUp ();
			} else {
				if (draggingItem)
					DropItem ();
			}
			Debug.Log ("MAX ATTEMPTS LEFT " + maxAttempts);
		}
		void OnEnable(){
			onAnswerChecked += AnswerCheckedHandler;
			IdleCheck.idleChangeDelegate += IdleChangeHandler;
			SimpleAlertView.okButtonClickDelegate += AlertViewOkButtonHandler;
			CellPlaceHolder.onCellStatusChangeDelegate += CellStatusChangeHandler;
		}
		void OnDestroy ()
		{
			onAnswerChecked -= AnswerCheckedHandler;
			OnLevelComplexityChange -= OnLevelComplexityChangeHandler;
			IdleCheck.idleChangeDelegate -= IdleChangeHandler;
			SimpleAlertView.okButtonClickDelegate -= AlertViewOkButtonHandler;
			CellPlaceHolder.onCellStatusChangeDelegate -= CellStatusChangeHandler;
		}
	#endregion
	#region PUBLIC METHODS
		public void CheckAnswer ()
		{
			// Logic for checking answer
			if (gameWordsUIManager.GetCellStatus () == CellStatus.PARTIALY_FILLED) {
				instructionSoundManager.PlayPartiallyReactionSound("GameWords");
			}
			bool result;
			userInput = GetInputFromUser ();
			string[] temp;
			int ansIndex = 0;
			if (!userInput.Contains (" ") && words [missionID].AnswersDict.TryGetValue ((int)LevelComplexity, out temp)) {
				ansIndex = Array.BinarySearch (temp, userInput);
			}
			if (ansIndex > 0) {
				Debug.Log ("ANSWER IS CORRECT -> " + ansIndex);	
				result = true;
				instructionSoundManager.PlayRightCombinationSound("GameWords");
				gameWordsUIManager.UpdateStarManager (currentQuestionIndex,result);
				currentQuestionIndex++;
			} else {
				Debug.Log ("ANSWER IS WRONG -> " + ansIndex);
				instructionSoundManager.PlayWrongCombinationSound("GameWords");
				if(maxAttempts > 0)
					maxAttempts--;
				if(maxAttempts==0)
					currentQuestionIndex++;
				result = false;

			}
			if (onAnswerChecked != null)
				onAnswerChecked (result);
		}
	#endregion
	#region PRIVATE METHODS
		private void CellStatusChangeHandler(CellStatus status){
			gameWordsUIManager.UpdateButtonSprites (status);
			switch (status) {
			case CellStatus.EMPTY:
				break;
			case CellStatus.PARTIALY_FILLED:
				//instructionSoundManager.PlayFullFilledReactionSound("GameWords");
				break;
			case CellStatus.FULLY_FILLED:
				instructionSoundManager.PlayFullReactionSound("GameWords");
				break;
			}
			Debug.Log ("HOW MANY TIMES CELL STATUS CHANGE HANDLER IS CALLED ");
		}
		private void AnswerCheckedHandler (bool isChecked){


			gameWordsUIManager.UpdateTiles (isChecked);
			UIDisabled = isChecked;// Disable UI if answer is correct
			gameWordsUIManager.DisabeUI (true);
			gameWordsUIManager.DisableButtons (true);
			StartCoroutine (NextQuestionUpdateDelay(nextQuestionDelay,isChecked));
		}
		private void SetupGame(){
			Debug.Log ("Setup Game");
			OnLevelComplexityChange += OnLevelComplexityChangeHandler;
			gameState = GameState.STARTED;
			ReferSceneObjects ();
			LevelComplexity = Complexity.One;
			sprites = LoadSprites ();
			CreateLettersForWord (missionID);

		}
		private void GenerateCells (Complexity lComplexity)
		{
			Debug.Log ("Generate Cells()");
			// Cells depend on level of complexity
			DeactivateCells ();
			for (int i = 0; i < (int)lComplexity; i++) {
				cells [i].SetActive (true);
			}
			gameWordsUIManager.SetupActiveCells ((int)lComplexity);
		}
		void IdleChangeHandler (bool flag)
		{
			UIDisabled = true;
			gameWordsUIManager.DisabeUI (!flag);
			instructionSoundManager.PlayCallToAction ("GameWords");

		} 
		void AlertViewOkButtonHandler(){
			UIDisabled = false;
			gameWordsUIManager.DisabeUI (true);
			SceneManager.LoadScene ("Maze");
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
			//Object letterPrefab = Resources.Load(letterPrefabPath, typeof(GameObject));
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
			words = new Word[wordsCount];
			string[] three = new string[12]{ "ТАМ", "ПУК", "УПС", "СУП", "САМ", "СЕТ", "РАК", "МАК", "КУМ", "СУК", "ТУП", "ПАТ" };
			Array.Sort (three);
			string[] four = new string[21] {
			"КУРТ",
			"КУРС",
			"КРУП",
			"УТЕС",
			"МЕРА",
			"ТЕМА",
			"ТРАП",
			"СТУК",
			"СЕРП",
			"УТКА",
			"РЕПС",
			"РЕПА",
			"РУКА",
			"РЕКА",
			"ПУМА",
			"ПАРК",
			"МАРС",
			"СТУК",
			"СКАТ",
			"СЕРА",
			"КРЕП"
		};
			Array.Sort (four);
			string[] five = new string[12] {
			"ТРЕСК",
			"ТУРКА",
			"ТЕРМА",
			"СПРУТ",
			"ТЕСАК",
			"ТРЕСК",
			"МАКЕТ",
			"СУПЕР",
			"СУМКА",
			"СЕКТА",
			"МЕТКА",
			"РЕПКА"
		};
			Array.Sort (five);
			string[] six = new string[8]{ "ПАРКЕТ", "СЕКРЕТ", "СТУПКА", "КАПЕРС", "МАРКЕТ", "ТРЕСКА", "МАРКЕР", "СТЕРКА" };
			Array.Sort (six);
			Dictionary<int,string[]> temp = new Dictionary<int, string[]> ();
			temp.Add (3, three);
			temp.Add (4, four);
			temp.Add (5, five);
			temp.Add (6, six);
			words [0] = new Word (){ Description = "СУПЕРМАРКЕТ", AnswersDict = temp};
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
		public void StartGameWordsGame ()
		{
			instructionSoundManager.PlayGameRule ("GameWords");
			//PopulateUIWithData (questions);
			//gameWordsUIManager.SetupActiveCells ((int)levelComplexity);
			
			
		}
		void PopulateUIWithData (Word[] qArray)
		{
//			if (quizUIManager != null && isActiveAndEnabled && currentQuestionIndex < qArray.Length) {
//				quizUIManager.PopulateUI (qArray [currentQuestionIndex]);
//				PlayQuestionSound (currentQuestionIndex);
//
//			}
		}

		private void PlayQuestionSound(int currrentQuestionIndex){
			//soundManager.PlaySound (questions [currentQuestionIndex].QuestionSound,2);
		}
		private void PlayAnswerSound(int currentQuestionIndex,int selectedButtonId){
			//soundManager.PlaySound (questions [currentQuestionIndex].AnswerSounds [selectedButtonId]);
		}
		private void ShowNextQuestion ()
		{	UIDisabled = false;
			gameWordsUIManager.ResetCheckButton ();
			gameWordsUIManager.ResetTileColors ();
			gameWordsUIManager.ResetTilePositions ();
			gameWordsUIManager.DisableButtons (false);
			if (currentQuestionIndex < maxQuestions) {
				NextLevelComplexity(currentQuestionIndex);
				maxAttempts = 2;
			}else {
				UIDisabled = true;
				gameWordsUIManager.DisabeUI (false);
				gameWordsUIManager.DisableButtons(true);
				EndGameWordsGame ();
			}
		}
		private void NextLevelComplexity(int level){
			switch(level){
			case 0:
				LevelComplexity = Complexity.One;
				break;
			case 1:
				LevelComplexity = Complexity.Two;
				break;
			case 2:
				LevelComplexity = Complexity.Three;
				break;
			case 3:
				LevelComplexity = Complexity.Four;
				break;
			case 4:
				LevelComplexity = Complexity.Five;
				break;
			}
		}
		private IEnumerator NextQuestionUpdateDelay (float time,bool isChecked)
		{
			yield return new WaitForSeconds (time);
			UIDisabled = false;
			if (isChecked || maxAttempts == 0) {
				ShowNextQuestion ();
			}

			gameWordsUIManager.ResetTileColors ();
			gameWordsUIManager.ResetCheckButton ();
			//gameWordsUIManager.ResetTilePositions ();
				
		}

		public void EndGameWordsGame ()
		{
			instructionSoundManager.PlayEnd ("GameWords");
			ShowEndGameMessage ();
			XElement maze = RollerBall.maze;
			if (maze.Element ("GameOfWordsComplete").Value == "0") {
				maze.Element ("GameOfWordsComplete").Value = 1.ToString(); //completed
				maze.Element ("CompletedTasks").Value = (Int32.Parse(maze.Element ("CompletedTasks").Value) + 1).ToString();
			}
		}

		private void ShowEndGameMessage ()
		{
			if (UIAlertView.instance.active_alert_views.Count < 1)
				UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Поздравляем!", "message", "Вы закончили задание!!!", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
		}
		private void CheckForCellFill(int activeCells){ // Checks for fully or partially filled cells
			
		}
	#endregion
	}
}
