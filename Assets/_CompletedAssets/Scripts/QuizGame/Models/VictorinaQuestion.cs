using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuizGame{
[System.Serializable]
public class VictorinaQuestion {
	#region PRIVATE MEMBERS
	[SerializeField]
	private int questionID = 0;
	[SerializeField]
	private AudioClip questionSound;
	[SerializeField]
	private AudioClip[] answerSounds = new AudioClip[4];
	[SerializeField]
	private string soundPath = "Sounds/QuizGame/";
	[SerializeField]private string description;
	[SerializeField]private string[] answers;	
	[SerializeField]private int correctIndex;
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
	public AudioClip[] AnswerSounds {
		get {
			return this.answerSounds;
		}
		set {
			answerSounds = value;
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
	public string[] Answers {
		get {
			return answers;
		}
		set {
			answers = value;
		}
	}
	//[ExposeProperty]
	public int CorrectIndex {
		get {
			return correctIndex;
		}
		set {
			correctIndex = value;
		}
	}
	#endregion
	#region  CONSTRUCTOR METHODS
	public VictorinaQuestion(int id,string desc,string[] ans, int correctIndex){
		this.questionID = id;;
		this.description = desc;
		this.answers = ans;
		this.correctIndex = correctIndex;
		LoadAudios (soundPath);
	}
	#endregion
	#region PUBLIC METHODS

	#endregion
	private void LoadAudios(string path){	//"Sounds/QuizGame
		QuestionSound = Resources.Load (path+"Question_"+questionID+"/question", typeof(AudioClip)) as AudioClip;
		AnswerSounds[0] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_0", typeof(AudioClip)) as AudioClip; 
		AnswerSounds[1] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_1", typeof(AudioClip)) as AudioClip; 
		AnswerSounds[2] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_2", typeof(AudioClip)) as AudioClip;
		AnswerSounds[3] = Resources.Load (path+"Question_"+questionID+"/Answers/answer_3", typeof(AudioClip)) as AudioClip;
	}
}
}