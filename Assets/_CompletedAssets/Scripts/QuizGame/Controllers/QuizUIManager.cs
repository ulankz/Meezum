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

		#region DELEGATE AND EVENTS
		public delegate void OnButtonClickDelegate (string id);
		public static event OnButtonClickDelegate buttonClickDelegate;
		#endregion

		void Awake(){
			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER);
			if (gamePanel != null)
				buttonContainer = gamePanel.GetComponentsInChildren<QuizButton> ();
				questionLabel = gamePanel.GetComponentInChildren<QuizQuestionLabel> ();
		}

		void Start(){
			foreach (QuizButton qButton in buttonContainer) {
				qButton.onClick.AddListener (() => buttonClick(qButton.name));

			}
		}
		void Destroy(){
			foreach (QuizButton qButton in buttonContainer)
				qButton.onClick.RemoveAllListeners ();
		}
		private void buttonClick(string id){
			if (buttonClickDelegate != null) {
				buttonClickDelegate(id);
			}
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
		public void UpdateButtonSprites(bool correctChoice,int buttonIndex){
			switch (correctChoice) {
			case true:
				buttonContainer[buttonIndex].SetCorrectChoiceState();
				break;
			case false: 
				buttonContainer[buttonIndex].SetWrongChoiceState();
				break;
			
			}
		}
			#endregion
	

	}

}