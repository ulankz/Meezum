using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuizGame{
[System.Serializable]
public class Instructions {
	[SerializeField]
	AudioClip gameRule;
	[SerializeField]
	AudioClip callToAction;
	[SerializeField]
	AudioClip[] corrects;
	[SerializeField]
	AudioClip[] wrongs;
	[SerializeField]
	AudioClip end;
}
}