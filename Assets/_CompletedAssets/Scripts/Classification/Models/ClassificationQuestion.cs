using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Text.RegularExpressions;
using Random = System.Random;

namespace Classification{
[System.Serializable]
public class ClassificationQuestion {
	#region PRIVATE MEMBERS
	[SerializeField]
	private int questionID = 0;
	[SerializeField]
	private AudioClip questionSound;
//	[SerializeField]
//	private AudioClip[] answerSounds = new AudioClip[4];
	[SerializeField]
	private string soundPath = "Sounds/QuizGame/";
	[SerializeField]private string description;
	[SerializeField]
		private List<int> actorIds = new List<int>();// Randomly  selected actors
	[SerializeField]private int[] answerSet;
	//[SerializeField]private int[] correctAnswers = new int[4];
	[SerializeField]private Dictionary<int,int> correctAnswersDict = new Dictionary<int,int >();
	[SerializeField]
	private int correctAnswerSum;
	#endregion
	
	#region PUBLIC PROPERTIES
	
	public AudioClip QuestionSound {
		get {
			return this.questionSound;
		}
		set {
			questionSound = value;
		}
	}
	public int CorrectAnswerSum {
		get {
			return this.correctAnswerSum;
		}
		set {
			correctAnswerSum = value;	
			}
		}
	//[ExposeProperty]
	public string Description {
		get {
			return description;
		}
		set {
			description = value;
		}
	}
	//[ExposeProperty]
	public List<int> ActorIds {
		get {
				return actorIds;
		}
		set {
				actorIds = value;
		}
	}
	//[ExposeProperty]
	public int[] AnswerSet {
		get {
			return answerSet;
		}
		set {
			answerSet = value;
		}
	}
//	public int[] CorrectAnswers {
//		get {
//			return correctAnswers;
//		}
//		set {
//			correctAnswers = value;
//			}
//	}
		public Dictionary<int,int> CorrectAnswersDict {
			get {
				return correctAnswersDict;
			}
			set {
				correctAnswersDict = value;
			}
		}
	#endregion
	#region  CONSTRUCTOR METHODS
	public ClassificationQuestion(int id,string desc,int [] answerSet){
		this.questionID = id;
		this.description = desc;
		this.answerSet = answerSet;
		LoadAudios (soundPath);
			GenerateAnswers ();
		

	}
	#endregion
	#region PUBLIC METHODS
	
	#endregion
	private void LoadAudios(string path){	//"Sounds/Classification
		QuestionSound = Resources.Load (path+"Question_"+questionID+"/question", typeof(AudioClip)) as AudioClip;
//		AnswerSounds[0] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_0", typeof(AudioClip)) as AudioClip; 
//		AnswerSounds[1] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_1", typeof(AudioClip)) as AudioClip; 
//		AnswerSounds[2] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_2", typeof(AudioClip)) as AudioClip;
//		AnswerSounds[3] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_3", typeof(AudioClip)) as AudioClip;
	}

		public void GenerateAnswers(){
			GenerateRandomActor ();
			for(int i = 0; i < 4; i++){
				//correctAnswers[i] = answerSet[actorIds[i]-1];
				correctAnswersDict.Add(actorIds[i]-1,answerSet[actorIds[i]-1]);
			}

			if(!AtLeastOneCorrect(correctAnswersDict)){
				int searchIndex = searchIndexOf(1,answerSet);
			//	correctAnswers[0] = answerSet[searchIndex]; 
				correctAnswersDict.Add(searchIndex,answerSet[searchIndex]);
			}
			//for(int i = 0; i < 4; i++){
				//correctAnswerSum += correctAnswers[i];

			//}
			foreach(var item in correctAnswersDict.Values){
				correctAnswerSum += item;
			}
			//Debug.Log ("Question ID " + questionID + "has at least one correct answer " + AtLeastOneCorrect(correctAnswers));
		}
		private void GenerateRandomActor (){
			int randomActor;
			for(int i = 0; i < 4; i++ ){
				do{
					randomActor = IntUtil.Random(1,11);
				}
				while(actorIds.Contains(randomActor));
				actorIds.Add(randomActor);
			
			}
		}
		private bool AtLeastOneCorrect(int [] a){
			foreach (int item in a) {
				if (item == 1) 
					return true;
			}
			return false;
		}
		private bool AtLeastOneCorrect(Dictionary<int,int> a){
			if (a.ContainsValue (1))
				return true;
			return false;
		}
		private int searchIndexOf(int x,int[] a){
			int ansIndex = Array.IndexOf (a, 1);//BinarySearch (a, x);
			return ansIndex > 0? ansIndex: 0;
		}
}
}