using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace GameOfWords{
[System.Serializable]
public struct Word{
	private string description;
	private Dictionary<int,string[]> answersDict;
	public string Description{
		set{
			description = value;	
		}
		get{
			return description;
		}
	}
	public Dictionary<int,string[]> AnswersDict{
		set{ 
			answersDict = value;
		}
		get{ 
			return answersDict;
		}
	}
	public Word(string d, Dictionary<int,string[]> ans){
		description = d;
		answersDict = ans;
	}
}
}