using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace Classification{
public class ClassificationQuestionLabel : Text {
	#region PUBLIC METHODS
	public void UpdateQuestionLabel(string description){
		text = description;
	}
	#endregion
}
}
