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
		private Queue<VictorinaQuestion>
			questions = new Queue<VictorinaQuestion> ();

		// UI Fields
		[SerializeField]
		private QuizUIManager quizUIManager; 
		[SerializeField]
		private int questionCount;
		#endregion
		// Use this for initialization
		void Awake ()
		{
			quizUIManager = GameObject.FindGameObjectWithTag(Tags.QUIZ_UI_MANAGER).GetComponent<QuizUIManager>();
			if (quizUIManager == null)
				Debug.LogError ("QUIZ_UI_MANAGER IS NULL !!");
			GenerateQuestions ();
			if(questions.Count == 0)
				Debug.LogError ("QUESTIONS QUEUE IS EMPTY !!");
		}

		void Start ()
		{
			QuizUIManager.buttonClickDelegate += CheckAnswer ;
			questionCount = questions.Count;
			PopulateUIWithData (questions);

		}

		void GenerateQuestions ()
		{
			VictorinaQuestion q1 = new VictorinaQuestion ("Как ты поступишь, если незнакомый человек предложит пойти с ним?", new string[] {
				"Конечно пойду, он хочет помочь",
				"Пойду если он добрый",
				"Не пойду, и закричу, если он будет заставлять",
				"Пойду, если он знает мойх родителей"
			}, 2);
			VictorinaQuestion q2 = new VictorinaQuestion ("Что ты сделаешь, если родители долго делают покупки?", new string[] {
				"Пойду искать игрушки",
				"Буду торопить их быстрее сделать покупки",
				"Пойду искать других детей,чтобы пойграть",
				"Подожду и никуда от них не отойду"
			}, 3);
			VictorinaQuestion q3 = new VictorinaQuestion ("Как правильно держаться за маму в местах, где много людей?", new string[] {
				"Держаться за ее сумку",
				"Крепко держать за ее руку",
				"Держаться за ее одежду",
				"Можно вообще не держаться, а только видеть"
			}, 1);
			questions.Enqueue (q1);
			questions.Enqueue (q2);
			questions.Enqueue (q3);
		}

		void PopulateUIWithData (Queue<VictorinaQuestion> questions)
		{
			if (quizUIManager != null && isActiveAndEnabled) {
				quizUIManager.PopulateUIWithData(questions.Dequeue());
			}
		}

		public void CheckAnswer (string idString)
		{
			int id;
			if (Int32.TryParse (idString, out id)) {
				Debug.Log ("QButton was clicked " + id);
				quizUIManager.UpdateButtonSprites(false,id);
			}

		}
		void OnDestroy(){
			QuizUIManager.buttonClickDelegate -= CheckAnswer ;
		}
	}
}