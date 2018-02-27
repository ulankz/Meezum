using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuizGame;
public class UISegmentedControl : MonoBehaviour {
	public void SelectSegment(QuizButton qb){
		qb.IsSelected = true;
	}

}
