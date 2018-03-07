using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using UnityEngine;
using MeezumGame;
namespace QuizGame
{
	public class QuizGameManager : MonoBehaviour
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private static int
			questionSize = 3;
		[SerializeField]
		private VictorinaQuestion[] questions = new VictorinaQuestion[questionSize];
		private float nextQuestionUpdateDelay = 3f;
		// UI Fields
		[SerializeField]
		private QuizUIManager
			quizUIManager; 
		[SerializeField]
		private int
			questionCount;
		[SerializeField]
		private int
			currentQuestionIndex = 0;
		[SerializeField]
		private bool quizGameStarted;
		[SerializeField]
		private InstructionSoundManager soundManager;
		#endregion
		#region INTERNAL METHODS
		// Use this for initialization
		void Awake ()
		{
			quizUIManager = GameObject.FindGameObjectWithTag (Tags.QUIZ_UI_MANAGER).GetComponent<QuizUIManager> ();
			soundManager = GameObject.FindGameObjectWithTag (Tags.SOUND_MANAGER).GetComponent<InstructionSoundManager> ();
			if (quizUIManager == null)
				Debug.LogError ("QUIZ_UI_MANAGER IS NULL !!");
			GenerateQuestions ();
			if (questions.Length == 0)
				Debug.LogError ("QUESTIONS QUEUE IS EMPTY !!");
		}

		void Start ()
		{
			QuizUIManager.buttonSingleClickDelegate += SingleClickHandler;
			QuizUIManager.buttonDoubleClickDelegate += CheckAnswer;
			questionCount = questions.Length;

			StartQuizGame ();
		}

		void GenerateQuestions ()
		{
			VictorinaQuestion q1 = new VictorinaQuestion ("Как ты поступишь, если незнакомый человек предложит пойти с ним?", new string[] {
				"Конечно пойду, он хочет помочь",
				"Пойду если он добрый",
				"Не пойду, и закричу, если он будет заставлять",
				"Пойду, если он знает мойх родителей"
			}, 2,"Sounds/QuizGame/callToAction");
			VictorinaQuestion q2 = new VictorinaQuestion ("Что ты сделаешь, если родители долго делают покупки?", new string[] {
				"Пойду искать игрушки",
				"Буду торопить их быстрее сделать покупки",
				"Пойду искать других детей,чтобы пойграть",
				"Подожду и никуда от них не отойду"
			}, 3,"Sounds/QuizGame/callToAction");
			VictorinaQuestion q3 = new VictorinaQuestion ("Как правильно держаться за маму в местах, где много людей?", new string[] {
				"Держаться за ее сумку",
				"Крепко держать за ее руку",
				"Держаться за ее одежду",
				"Можно вообще не держаться, а только видеть"
			}, 1,"Sounds/QuizGame/callToAction");
			questions [0] = q1;
			questions [1] = q2;
			questions [2] = q3;
		}

		void PopulateUIWithData (VictorinaQuestion[] qArray)
		{
			if (quizUIManager != null && isActiveAndEnabled && currentQuestionIndex < qArray.Length) {
				quizUIManager.PopulateUI (qArray [currentQuestionIndex]);
				//currentQuestionIndex++;
			}
		}
		void OnDestroy ()
		{
			QuizUIManager.buttonSingleClickDelegate -= SingleClickHandler;
			QuizUIManager.buttonDoubleClickDelegate -= CheckAnswer;
		}
		void Update(){
			Debug.Log ("CURRENT_QUESTION_INDEX " + currentQuestionIndex);
		}
		#endregion
		#region PUBLIC METHODS
		public void CheckAnswer (string idString)
		{
		
			int id;
			if (Int32.TryParse (idString, out id)) {
				//Debug.Log (" CHECK ANSWER IS CALLED " + id);
				if (currentQuestionIndex < questions.Length) {
					CheckCurrentAnswer (id, questions [currentQuestionIndex]);
					StartCoroutine (NextQuestionUpdateDelay (nextQuestionUpdateDelay));
					currentQuestionIndex++;
				}
			}
		}
		public void SingleClickHandler(string idString)
		{
			int id;
			if (Int32.TryParse (idString, out id)) {
				//Debug.Log (" SINGLE_CLICK_HANDLER IS CALLED " + id);

			}
		}
		public void StartQuizGame ()
		{
			soundManager.PlayGameRule ("QuizGame");
			//questions[currentQuestionIndex].
			PopulateUIWithData (questions);

		}
		public void EndQuizGame ()
		{
			soundManager.PlayEnd ("QuizGame");
			ShowEndGameMessage ();
		}
		#endregion
		#region PRIVATE METHODS
		private void ShowNextQuestion ()
		{	
			quizUIManager.ResetButtonSprites();
			if (currentQuestionIndex < questions.Length) {
				PopulateUIWithData (questions);
			}else {
				EndQuizGame ();
			}
		}
		private IEnumerator NextQuestionUpdateDelay (float time)
		{
			yield return new WaitForSeconds (time);
			ShowNextQuestion ();
		}
		private void ShowEndGameMessage ()
		{
			if (UIAlertView.instance.active_alert_views.Count < 1)
				UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Game Completed", "message", "Well Done!!!", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
		}
		private void CheckCurrentAnswer (int selectedId, VictorinaQuestion currentQuestion)
		{
			//Debug.Log ("CHECK_CURRENT_ANSWER IS CALLED " + "SELECTED_ID "+ selectedId +" CORRECT_INDEX " + currentQuestion.CorrectIndex);
			if (selectedId == currentQuestion.CorrectIndex) {
				// ADD star to StarManager
				quizUIManager.UpdateButtonSprites (1, selectedId);

			} else {
				quizUIManager.UpdateButtonSprites (1, currentQuestion.CorrectIndex);
				quizUIManager.UpdateButtonSprites(2,selectedId);
			}
		}
	
		#endregion


	}
}