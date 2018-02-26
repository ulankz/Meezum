using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
namespace QuizGame
{
	public class QuizUIManager : MonoBehaviour, UIManagable
	{

		#region PRIVATE MEMBERS
		[SerializeField]
		private GameObject quizPanel;
		[SerializeField]
		private Image character;
		[SerializeField]
		private GameObject gamePanel;
		[SerializeField]
		private QuizButton[] buttonContainer;
		[SerializeField] 
		private GameObject questionPanel;
		[SerializeField]
		private QuizQuestionLabel questionLabel;
		[SerializeField]
		private GameObject starManager;	
		#endregion
		void Awake(){
			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER);
			if (gamePanel != null)
				buttonContainer = gamePanel.GetComponentsInChildren<QuizButton> ();
				questionLabel = gamePanel.GetComponentInChildren<QuizQuestionLabel> ();
		}
		#region PUBLIC METHODS
		public void PopulateUIWithData(VictorinaQuestion question){
			if (questionLabel != null)
				questionLabel.UpdateQuestionLabel (question.Description);
			if (buttonContainer != null && buttonContainer.Length > 0) {
				int i = 0;
				foreach(QuizButton qButton in buttonContainer){

					qButton.UpdateButton(question.Answers[i]);
					i++;
				}
				i=0;
			}
		}
			#endregion
	}
}