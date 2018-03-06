using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuizGame{
[System.Serializable]
public class VictorinaQuestion {
	#region PRIVATE MEMBERS
	private AudioClip questionSound;
	[SerializeField]private string description;
	[SerializeField]private string[] answers;	
	[SerializeField]private int correctIndex;
	#endregion

	#region PUBLIC PROPERTIES
	AudioClip QuestionSound {
		get {
			return this.questionSound;
		}
		set {
			questionSound = value;
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
	public VictorinaQuestion(string desc,string[] ans, int correctIndex,string audioPath){
		description = desc;
		answers = ans;
		this.correctIndex = correctIndex;
		LoadAudios (audioPath);
	}
	#endregion
	#region PUBLIC METHODS
	public void PlayQuestionSound(){
		
	}
	#endregion
	private void LoadAudios(string path){//"Sounds/QuizGame/callToAction"
		QuestionSound = Resources.Load (path, typeof(AudioClip)) as AudioClip;
	}
}
}