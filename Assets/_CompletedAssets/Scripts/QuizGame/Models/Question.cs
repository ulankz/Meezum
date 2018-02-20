using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[System.Serializable]
public class Question {
	[SerializeField]private string description;
	[SerializeField]private string[] answers;
	[SerializeField]private int correctIndex;

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
	public Question(string desc,string[] ans, int correctIndex){
		description = desc;
		answers = ans;
		this.correctIndex = correctIndex;
	}
}
