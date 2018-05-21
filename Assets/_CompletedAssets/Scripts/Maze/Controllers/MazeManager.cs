
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEditor;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Array = System.Array;
using MeezumGame;

namespace Maze
{
	public class MazeManager : MonoBehaviour
	{
	
	#region PRIVATE MEMBERS
		public GameObject wall;
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
		private const string
			spriteLoadPath = "GameOfWords/Alphabets";
		// UI Fields
		[SerializeField]
		private MazeUIManager
			mazeUIManager; 
		[SerializeField]
		private InstructionSoundManager
			instructionSoundManager;
		[SerializeField]
		private SoundManager
			soundManager;
		[SerializeField]
		private IdleCheck
			notificationManager;
		[SerializeField]
		private int
			currentQuestionIndex = 0;
		private float nextQuestionDelay = 2f;
		private int maxQuestions = 5;
		private bool UIDisabled = false;
		[SerializeField]
		private static int
			questionSize = 10;
	//	[SerializeField]
//		private ClassificationQuestion[]
//			questions = new ClassificationQuestion[questionSize];
		// UI Fields
		[SerializeField]
		private int
			questionCount;
		[SerializeField]
		private bool
			classificationStarted;
		[SerializeField]
		Dictionary<int,bool>
			tracker = new Dictionary<int,bool> ();
	#endregion
	#region DELEGATES AND EVENTS
		public delegate void OnAnswerCheckedDelegate (bool answered);
		public event OnAnswerCheckedDelegate onAnswerChecked;
		[SerializeField]
//		private List<Actor>
//			selectedSprites;
	#endregion
	#region PUBLIC PROPERTIES


	#endregion
	#region SYSTEM METHODS
		void Awake ()
		{
			transform.tag = Tags.CLASSIFICATION_GAME_MANAGER;
			//mazeUIManager = GameObject.FindGameObjectWithTag (Tags.CLASSIFICATION_UI_MANAGER).GetComponent<MazeUIManager> ();
			instructionSoundManager = GameObject.FindGameObjectWithTag (Tags.INSTRUCTIONS_SOUND_MANAGER).GetComponent<InstructionSoundManager> ();
			soundManager = GameObject.FindGameObjectWithTag (Tags.SOUND_MANAGER).GetComponent<SoundManager> ();
			notificationManager = GameObject.FindGameObjectWithTag (Tags.NOTIFICATION_MANAGER).GetComponent<IdleCheck> ();
//			if (mazeUIManager == null)
//				Debug.LogError ("CLASSIFICATION_UI_MANAGER IS NULL !!");
//			GenerateQuestions ();
		//	selectedSprites = new List<Actor> ();
		}
	#endregion
	#region PUBLIC METHODS

	#endregion
	#region PRIVATE METHODS
		private void AnswerCheckedHandler (bool isChecked)
		{
			//classificationUIManager.UpdateTiles (isChecked);
			UIDisabled = isChecked;// Disable UI if answer is correct
			mazeUIManager.DisabeUI (true);
			mazeUIManager.DisableButtons (true);
			//StartCoroutine (NextQuestionUpdateDelay(nextQuestionDelay,isChecked));
		}
		private void SetupGame ()
		{
			Debug.Log ("Setup Game");
			//OnLevelComplexityChange += OnLevelComplexityChangeHandler;
			//gameState = GameState.STARTED;
			ReferSceneObjects ();
			//sprites = LoadSprites ();
			//	CreateLettersForWord (missionID);
		}
		void IdleChangeHandler (bool flag)
		{
			UIDisabled = true;
			mazeUIManager.DisabeUI (!flag);
			instructionSoundManager.PlayCallToAction ("GameWords");
		} 
		void AlertViewOkButtonHandler ()
		{
			UIDisabled = false;
			mazeUIManager.DisabeUI (true);
		}
		private void ReferSceneObjects ()
		{
			question = GameObject.FindGameObjectWithTag (Tags.CLASSIFICATION_QUESTION_PANEL).transform;
			//cells = GameObject.FindGameObjectsWithTag (Tags.CELL).OrderBy (g => g.name).ToArray ();
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
//		void Start ()
//		{
//			RegisterForActorSelectedDelegate ();		
//	//		questionCount = questions.Length;
//			//StartQuizGame ();
//			Debug.Log ("START QUIZ GAME");
//		}
		private void RegisterForActorSelectedDelegate ()
		{
//			mazeUIManager.ActorsContainer [0].onActorSelected += ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [0].onActorDeselected += ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [1].onActorSelected += ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [1].onActorDeselected += ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [2].onActorSelected += ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [2].onActorDeselected += ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [3].onActorSelected += ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [3].onActorDeselected += ActorDeselectedHandler;
		}
		private void UnRegisterFromActorSelectedDelegate ()
		{
//			mazeUIManager.ActorsContainer [0].onActorSelected -= ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [0].onActorDeselected -= ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [1].onActorSelected -= ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [1].onActorDeselected -= ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [2].onActorSelected -= ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [2].onActorDeselected -= ActorDeselectedHandler;
//			mazeUIManager.ActorsContainer [3].onActorSelected -= ActorSelectedHandler;
//			mazeUIManager.ActorsContainer [3].onActorDeselected -= ActorDeselectedHandler;
		}
		void OnEnable ()
		{
			onAnswerChecked += AnswerCheckedHandler;
			IdleCheck.idleChangeDelegate += IdleChangeHandler;
			SimpleAlertView.okButtonClickDelegate += AlertViewOkButtonHandler;
		}
		void OnDisable ()
		{
			UnRegisterFromActorSelectedDelegate ();
			onAnswerChecked -= AnswerCheckedHandler;
			IdleCheck.idleChangeDelegate -= IdleChangeHandler;
			SimpleAlertView.okButtonClickDelegate -= AlertViewOkButtonHandler;
		}
//		private void ActorDeselectedHandler (Actor actor)
//		{
//			if (selectedSprites.Contains (actor))
//				selectedSprites.Remove (actor);
//		}
//		private void ActorSelectedHandler (Actor actor)
//		{
//			if (!selectedSprites.Contains (actor))
//				selectedSprites.Add (actor);
//		}
		void GenerateQuestions ()
		{

		}
		void PopulateUIWithData ()
		{
//			if (classificationUIManager != null && isActiveAndEnabled && currentQuestionIndex < qArray.Length) {
//				classificationUIManager.PopulateUI (qArray [currentQuestionIndex]);
//				PlayQuestionSound (currentQuestionIndex);
//			}
		}
		#endregion
		#region PUBLIC METHODS

		public void CheckAnswer ()
		{
//			//Debug.Log ("Check Answer is pressed");
//			if (currentQuestionIndex < 5) {//questions.Length
//				CheckCurrentAnswer (questions [currentQuestionIndex]);
//				Debug.Log ("CURRENT QUESTION INDEX IS " + currentQuestionIndex);
//				classificationUIManager.DisabeUI (false); //Uncoment here
//				StartCoroutine (NextQuestionUpdateDelay (nextQuestionDelay));
//				currentQuestionIndex++;
//			}
		}

		public void StartQuizGame ()
		{
			//instructionSoundManager.PlayGameRule ("Classification");

			PopulateUIWithData ();
			Debug.Log ("POPULATE UI WITH DATA CLASSIFICATION MANAGER");
			
			
		}
		public void EndQuizGame ()
		{
			instructionSoundManager.PlayEnd ("QuizGame");
			ShowEndGameMessage ();
			
		}
		private void PlaySingleClickCallToAction ()
		{// After single click 5 sec of inactivity
			instructionSoundManager.PlayCallFirstClickToAction ("QuizGame");
		}
		#endregion
		#region PRIVATE METHODS

		private void PlayQuestionSound (int currrentQuestionIndex)
		{
			//soundManager.PlaySound (questions [currentQuestionIndex].QuestionSound,2);
		}
		private void PlayAnswerSound (int currentQuestionIndex, int selectedButtonId)
		{
			//soundManager.PlaySound (questions [currentQuestionIndex].AnswerSounds [selectedButtonId]);
		}
		private void ShowNextQuestion ()
		{
//			classificationUIManager.DisabeUI (true);
//			//classificationUIManager.ResetButtonSprites();
//			if (currentQuestionIndex < 5) {//questions.Length
//				PopulateUIWithData (questions);
//			} else {
//				classificationUIManager.DisabeUI (false);
//				classificationUIManager.DisableButtons (true);
//				EndQuizGame ();
//			}
		}


		private IEnumerator NextQuestionUpdateDelay (float time)
		{
			yield return new WaitForSeconds (time);
			//if(selectedSprites.Count > 0)
			ShowNextQuestion ();
//			classificationUIManager.ResetCheckButton ();
//			classificationUIManager.UpdateActorSprites ();
		}
		private void ShowEndGameMessage ()
		{
			if (UIAlertView.instance.active_alert_views.Count < 1)
				UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Game Completed", "message", "Well Done!!!", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
		}
//		private void CheckCurrentAnswer (ClassificationQuestion currentQuestion)
//		{
//
//			Debug.Log ("Check answer is clicked " + currentQuestionIndex);
//			int selectedAnswersCount = selectedSprites.Count ();
//			CheckSelectedSprites (selectedAnswersCount, currentQuestion);
//		}
//		private void CheckSelectedSprites (int selectedAnswerCount, ClassificationQuestion currentQuestion)
//		{
//			int correctAnswersCount = currentQuestion.CorrectAnswersDict.Count ();
//			int selectedSum = 0;
//			foreach (var key in currentQuestion.CorrectAnswersDict.Keys) {
//				tracker.Add (key, false);
//			}
//			for (int i = 0; i < selectedAnswerCount; i++) {
//				if (currentQuestion.CorrectAnswersDict [selectedSprites [i].Id - 1] == 1) {
//					Debug.Log ("ANSWER IS CORRECT AT INDEX " + selectedSprites [i].Index);
//					classificationUIManager.UpdateActorSprites (1, selectedSprites [i].Index);
//					selectedSum++;
//				} else {
//					if (currentQuestion.CorrectAnswersDict [selectedSprites [i].Id - 1] == 0) {
//						Debug.Log ("ANSWER IS WRONG AT INDEX " + selectedSprites [i].Index);
//						classificationUIManager.UpdateActorSprites (2, selectedSprites [i].Index);
//						selectedSum--;
//					}
//				}
//				tracker [selectedSprites [i].Id - 1] = true;
//			}
//			if (selectedAnswerCount < tracker.Count)
//				for (int i = 0; i < tracker.Count; i++) {
//					var element = tracker.ElementAt (i);
//					if (element.Value == false) {
//						if (currentQuestion.CorrectAnswersDict [element.Key] == 1) {
//							classificationUIManager.UpdateActorSprites (1, i);
//							Debug.Log ("CHECK ME > ERROR FIRES HERE " + i);
//						} else {
//							classificationUIManager.UpdateActorSprites (2, i);
//						}
//						Debug.Log ("TRACKER OBJECT IS NOT YET CHECKED");
//					}
//				}
//			if (selectedSum == currentQuestion.CorrectAnswerSum) {
//				classificationUIManager.UpdateStarManager (currentQuestionIndex, true);
//			}
//			tracker.Clear ();
//			selectedSprites.Clear ();
//		}
		void Update ()
		{
//			// Code for OnMouseDown in the iPhone. Unquote to test.
//			RaycastHit hit = new RaycastHit ();
//			for (int i = 0; i < Input.touchCount; ++i) {
//				if (Input.GetTouch (i).phase.Equals (TouchPhase.Began)) {
//					// Construct a ray from the current touch coordinates
//					Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (i).position);
//					if (Physics.Raycast (ray, out hit)) {
//						hit.transform.gameObject.SendMessage ("OnMouseDown");
////						Debug.Log("Hits " + hit.transform.gameObject.name);
////						if(hit.transform.gameObject.tag == Tags.CLASSIFICATION_CHECK_BUTTON){
////							CheckAnswer();
////
////						}
//					}
//				}
//			}
		}
	#endregion
		void Start ()
			
		{
			
			TextAsset t1 = (TextAsset)Resources.Load("Maze/maze", typeof(TextAsset));
			
			string s = t1.text;
			
			int i, j;
			
			s = s.Replace("\n","");
			
			for (i = 0; i < s.Length; i++)
				
			{
				
				if (s [i] == '1')
					
				{
					
					int column, row;
					
					column = i%10;
					
					row = i / 10;
					
					GameObject t;
					
					t = (GameObject)(Instantiate (wall, new Vector3 (50 - column * 10, 1.5f, 50 - row * 10), Quaternion.identity));
					t.transform.SetParent(transform);
				}
				
			}
			
		}
	}
}
