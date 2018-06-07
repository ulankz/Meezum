
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
//using UnityEditor;
using System.Diagnostics;
using Debug = UnityEngine.Debug;
using Array = System.Array;
using MeezumGame;
using UnityEngine.SceneManagement;

namespace Classification
{
	public class ClassificationManager : MonoBehaviour
	{
	
	#region PRIVATE MEMBERS
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
			spriteLoadPath = "Classification/";
		// UI Fields
		[SerializeField]
		private ClassificationUIManager
			classificationUIManager; 
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
		[SerializeField]
		private ClassificationQuestion[]
			questions = new ClassificationQuestion[questionSize];
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
		private List<Actor>
			selectedSprites;
	#endregion
	#region PUBLIC PROPERTIES


	#endregion
	#region SYSTEM METHODS
		void Awake ()
		{
			transform.tag = Tags.CLASSIFICATION_GAME_MANAGER;
			classificationUIManager = GameObject.FindGameObjectWithTag (Tags.CLASSIFICATION_UI_MANAGER).GetComponent<ClassificationUIManager> ();
			instructionSoundManager = GameObject.FindGameObjectWithTag (Tags.INSTRUCTIONS_SOUND_MANAGER).GetComponent<InstructionSoundManager> ();
			soundManager = GameObject.FindGameObjectWithTag (Tags.SOUND_MANAGER).GetComponent<SoundManager> ();
			notificationManager = GameObject.FindGameObjectWithTag (Tags.NOTIFICATION_MANAGER).GetComponent<IdleCheck> ();
			if (classificationUIManager == null)
				Debug.LogError ("CLASSIFICATION_UI_MANAGER IS NULL !!");
			GenerateQuestions ();
			selectedSprites = new List<Actor> ();
		}
	#endregion
	#region PUBLIC METHODS

	#endregion
	#region PRIVATE METHODS
		private void AnswerCheckedHandler (bool isChecked)
		{
			//classificationUIManager.UpdateTiles (isChecked);
			UIDisabled = isChecked;// Disable UI if answer is correct
			classificationUIManager.DisabeUI (true);
			classificationUIManager.DisableButtons (true);
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
			classificationUIManager.DisabeUI (!flag);
			instructionSoundManager.PlayCallToAction ("GameWords");
		} 
		void AlertViewOkButtonHandler ()
		{
			UIDisabled = false;
			classificationUIManager.DisabeUI (true);
			SceneManager.LoadScene ("Maze");
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
		void Start ()
		{
			RegisterForActorSelectedDelegate ();		
			questionCount = questions.Length;
			StartQuizGame ();
			Debug.Log ("START QUIZ GAME");
		}
		private void RegisterForActorSelectedDelegate ()
		{
			classificationUIManager.ActorsContainer [0].onActorSelected += ActorSelectedHandler;
			classificationUIManager.ActorsContainer [0].onActorDeselected += ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [1].onActorSelected += ActorSelectedHandler;
			classificationUIManager.ActorsContainer [1].onActorDeselected += ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [2].onActorSelected += ActorSelectedHandler;
			classificationUIManager.ActorsContainer [2].onActorDeselected += ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [3].onActorSelected += ActorSelectedHandler;
			classificationUIManager.ActorsContainer [3].onActorDeselected += ActorDeselectedHandler;
		}
		private void UnRegisterFromActorSelectedDelegate ()
		{
			classificationUIManager.ActorsContainer [0].onActorSelected -= ActorSelectedHandler;
			classificationUIManager.ActorsContainer [0].onActorDeselected -= ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [1].onActorSelected -= ActorSelectedHandler;
			classificationUIManager.ActorsContainer [1].onActorDeselected -= ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [2].onActorSelected -= ActorSelectedHandler;
			classificationUIManager.ActorsContainer [2].onActorDeselected -= ActorDeselectedHandler;
			classificationUIManager.ActorsContainer [3].onActorSelected -= ActorSelectedHandler;
			classificationUIManager.ActorsContainer [3].onActorDeselected -= ActorDeselectedHandler;
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
		private void ActorDeselectedHandler (Actor actor)
		{
			if (selectedSprites.Contains (actor))
				selectedSprites.Remove (actor);
		}
		private void ActorSelectedHandler (Actor actor)
		{
			if (!selectedSprites.Contains (actor))
				selectedSprites.Add (actor);
		}
		void GenerateQuestions ()
		{
			ClassificationQuestion q1 = new ClassificationQuestion (1, "Нажми на всех взрослых посетителей магазина?", new int[] {
				1,1,1,0,0,1,1,1,0,0
			});
			ClassificationQuestion q2 = new ClassificationQuestion (2, "Нажми на всех мужчин посетителей магазина?", new int[] {
				1,1,1,1,1,0,0,0,0,0
			});
			ClassificationQuestion q3 = new ClassificationQuestion (3, "Нажми на всех худых посетителей магазина?", new int[] {
				1,0,1,0,1,1,1,0,1,1
			});
			ClassificationQuestion q4 = new ClassificationQuestion (4, "Нажми на всех посетителей магазина  в желтой одежде?", new int[] {
				0,0,0,1,0,0,1,0,0,0
			});
			ClassificationQuestion q5 = new ClassificationQuestion (5, "Нажми на всех посетителей магазина в очках?", new int[] {
				0,1,1,1,0,1,1,0,0,0
			});
			ClassificationQuestion q6 = new ClassificationQuestion (6, "Нажми на всех посетителей магазина в униформе?", new int[] {
				1,0,0,0,0,0,0,0,0,0
			});
			ClassificationQuestion q7 = new ClassificationQuestion (7, "Нажми на всех посетителей магазина с сумками?", new int[] {
				0,0,1,1,0,1,1,0,1,0
			});
			ClassificationQuestion q8 = new ClassificationQuestion (8, "Нажми на всех посетителей магазина с коляской?", new int[] {
				0,0,0,0,0,1,0,0,0,0
			});
			ClassificationQuestion q9 = new ClassificationQuestion (9, "Нажми на всех посетителей магазина в головном уборе?", new int[] {
				1,1,0,0,0,0,1,0,1,1
			});
			ClassificationQuestion q10 = new ClassificationQuestion (10, "Нажми на всех высоких посетителей магазина?", new int[] {
				1,0,1,1,0,0,1,0,1,0
			});
			questions [0] = q1;
			questions [1] = q2;
			questions [2] = q3;
			questions [3] = q4;
			questions [4] = q5;
			questions [5] = q6;
			questions [6] = q7;
			questions [7] = q8;
			questions [8] = q9;
			questions [9] = q10;
		}
		void PopulateUIWithData (ClassificationQuestion[] qArray)
		{
			if (classificationUIManager != null && isActiveAndEnabled && currentQuestionIndex < qArray.Length) {
				classificationUIManager.PopulateUI (qArray [currentQuestionIndex]);
				PlayQuestionSound (currentQuestionIndex);
			}
		}
		#endregion
		#region PUBLIC METHODS
		public void CheckAnswer ()
		{
			Debug.Log ("Check Answer is pressed");
			if (currentQuestionIndex < 5) {//questions.Length
				CheckCurrentAnswer (questions [currentQuestionIndex]);
				Debug.Log ("CURRENT QUESTION INDEX IS " + currentQuestionIndex);
				classificationUIManager.DisabeUI (false); //Uncoment here
				StartCoroutine (NextQuestionUpdateDelay (nextQuestionDelay));
				currentQuestionIndex++;
			}
		}
		public void StartQuizGame ()
		{
			//instructionSoundManager.PlayGameRule ("Classification");
			UIDisabled = false;
			PopulateUIWithData (questions);
			Debug.Log ("POPULATE UI WITH DATA CLASSIFICATION MANAGER");
			
			
		}
		public void EndQuizGame ()
		{
			instructionSoundManager.PlayEnd ("QuizGame");
			ShowEndGameMessage ();


			if (PlayerPrefs.GetInt ("CompletedTasks", 0) != null) {
				int completedTasks = PlayerPrefs.GetInt ("CompletedTasks", 0);
				PlayerPrefs.SetInt("CompletedTasks", completedTasks+1);
			}


			
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
			classificationUIManager.DisabeUI (true);
			//classificationUIManager.ResetButtonSprites();
			if (currentQuestionIndex < 5) {//questions.Length
				PopulateUIWithData (questions);
			} else {
				classificationUIManager.DisabeUI (false);
				classificationUIManager.DisableButtons (true);
				UIDisabled = true;
				EndQuizGame ();
			}
		}
		private IEnumerator NextQuestionUpdateDelay (float time)
		{
			yield return new WaitForSeconds (time);
			//if(selectedSprites.Count > 0)
			ShowNextQuestion ();
			classificationUIManager.ResetCheckButton ();
			classificationUIManager.UpdateActorSprites ();
		}
		private void ShowEndGameMessage ()
		{
			if (UIAlertView.instance.active_alert_views.Count < 1)
				UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Поздравляем!", "message", "Вы закончили задание!!!", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
			
		}
		private void CheckCurrentAnswer (ClassificationQuestion currentQuestion)
		{

			Debug.Log ("Check answer is clicked " + currentQuestionIndex);
			int selectedAnswersCount = selectedSprites.Count ();
			CheckSelectedSprites (selectedAnswersCount, currentQuestion);
		}
		private void CheckSelectedSprites (int selectedAnswerCount, ClassificationQuestion currentQuestion)
		{
			int correctAnswersCount = currentQuestion.CorrectAnswersDict.Count ();
			int selectedSum = 0;
			foreach (var key in currentQuestion.CorrectAnswersDict.Keys) {
				tracker.Add (key, false);
			}
			for (int i = 0; i < selectedAnswerCount; i++) {
				if (currentQuestion.CorrectAnswersDict [selectedSprites [i].Id - 1] == 1) {
					Debug.Log ("ANSWER IS CORRECT AT INDEX " + selectedSprites [i].Index);
					classificationUIManager.UpdateActorSprites (1, selectedSprites [i].Index);
					selectedSum++;
				} else {
					if (currentQuestion.CorrectAnswersDict [selectedSprites [i].Id - 1] == 0) {
						Debug.Log ("ANSWER IS WRONG AT INDEX " + selectedSprites [i].Index);
						classificationUIManager.UpdateActorSprites (2, selectedSprites [i].Index);
						selectedSum--;
					}
				}
				tracker [selectedSprites [i].Id - 1] = true;
			}
			if (selectedAnswerCount < tracker.Count)
				for (int i = 0; i < tracker.Count; i++) {
					var element = tracker.ElementAt (i);
					if (element.Value == false) {
						if (currentQuestion.CorrectAnswersDict [element.Key] == 1) {
							classificationUIManager.UpdateActorSprites (1, i);
							Debug.Log ("CHECK ME > ERROR FIRES HERE " + i);
					} else if (currentQuestion.CorrectAnswersDict [element.Key] == 0){
							classificationUIManager.UpdateActorSprites (2, i);
						}
						Debug.Log ("TRACKER OBJECT IS NOT YET CHECKED");
					}
				}
			if (selectedSum == currentQuestion.CorrectAnswerSum) {
				classificationUIManager.UpdateStarManager (currentQuestionIndex, true);
			}
			tracker.Clear ();
			selectedSprites.Clear ();
		}
		void Update ()
		{
			// Code for OnMouseDown in the iPhone. Unquote to test.
			RaycastHit hit = new RaycastHit ();
			for (int i = 0; i < Input.touchCount; ++i) {
				if (Input.GetTouch (i).phase.Equals (TouchPhase.Began)) {
					// Construct a ray from the current touch coordinates
					Ray ray = Camera.main.ScreenPointToRay (Input.GetTouch (i).position);
					if (Physics.Raycast (ray, out hit) && UIDisabled) {
						hit.transform.gameObject.SendMessage ("OnMouseDown");
//						Debug.Log("Hits " + hit.transform.gameObject.name);
//						if(hit.transform.gameObject.tag == Tags.CLASSIFICATION_CHECK_BUTTON){
//							CheckAnswer();
//
//						}
					
					}
				}
			}
		}
	#endregion
	
	}
}
