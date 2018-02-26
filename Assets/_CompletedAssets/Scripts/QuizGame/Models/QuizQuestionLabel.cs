using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class QuizQuestionLabel : Text {
	#region PUBLIC METHODS
	public void UpdateQuestionLabel(string description){
		text = description;
	}
	#endregion

}
