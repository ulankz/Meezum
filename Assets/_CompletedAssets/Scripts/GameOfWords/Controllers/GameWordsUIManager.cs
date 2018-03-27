using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
namespace QuizGame
{
	public class GameWordsUIManager : MonoBehaviour, UIManagable
	{

//		#region PRIVATE MEMBERS
//		[SerializeField]
//		private GameObject quizPanel;
//		[SerializeField]
//		private CanvasGroup quizPanelCanvasGroup;
//		[SerializeField]
//		private Image character;
//		[SerializeField]
//		private GameObject gamePanel;
//		[SerializeField]
//		private QuizButton[] buttonContainer;
//		[SerializeField] 
//		private GameObject questionPanel;
//		[SerializeField]
//		private QuizQuestionLabel questionLabel;
//		[SerializeField]
//		private StarManager starManager;	
//		#endregion
//
//		#region DELEGATE AND EVENTS
//		public delegate void OnButtonSingleClickDelegate (string id);
//		public static event OnButtonSingleClickDelegate buttonSingleClickDelegate;
//		public delegate void OnButtonDoubleClickDelegate (string id);
//		public static event OnButtonDoubleClickDelegate buttonDoubleClickDelegate;
//
//		#endregion
//
//		void Awake(){
//			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER).GetComponent<StarManager>();
//			if (gamePanel != null) {
//				buttonContainer = gamePanel.GetComponentsInChildren<QuizButton> ();
//				questionLabel = gamePanel.GetComponentInChildren<QuizQuestionLabel> ();
//			}
//			if (quizPanel != null) {
//				quizPanelCanvasGroup = quizPanel.GetComponent<CanvasGroup>(); 
//			}
//		}
//
//		void OnEnable(){
//			// HANDLES THE PROBLEM OFF ADDING LISTENERS THORUGH FOR LOOP
//				buttonContainer[0].onSingleClickAction.AddListener(() => buttonSingleClickHandler(buttonContainer[0].name));
//				buttonContainer[0].onDoubleClickAction.AddListener(() => buttonDoubleClickHandler(buttonContainer[0].name));
//				buttonContainer[1].onSingleClickAction.AddListener(() => buttonSingleClickHandler(buttonContainer[1].name));
//				buttonContainer[1].onDoubleClickAction.AddListener(() => buttonDoubleClickHandler(buttonContainer[1].name));
//				buttonContainer[2].onSingleClickAction.AddListener(() => buttonSingleClickHandler(buttonContainer[2].name));
//				buttonContainer[2].onDoubleClickAction.AddListener(() => buttonDoubleClickHandler(buttonContainer[2].name));
//				buttonContainer[3].onSingleClickAction.AddListener(() => buttonSingleClickHandler(buttonContainer[3].name));
//				buttonContainer[3].onDoubleClickAction.AddListener(() => buttonDoubleClickHandler(buttonContainer[3].name));
//		}
//		void OnDisable(){
//			buttonContainer[0].onClick.RemoveAllListeners ();
//			buttonContainer[1].onClick.RemoveAllListeners ();
//			buttonContainer[2].onClick.RemoveAllListeners ();
//			buttonContainer[3].onClick.RemoveAllListeners ();
//		}
//		public void buttonSingleClickHandler(string id){
//			if (buttonSingleClickDelegate != null) {
//				buttonSingleClickDelegate(id);
//			}
//		}
//		public void buttonDoubleClickHandler(string id){
//			if (buttonDoubleClickDelegate != null) {
//				buttonDoubleClickDelegate(id);
//			}
//		}
//
//		#region PUBLIC METHODS
//		public void PopulateUI(VictorinaQuestion question){
//			if (questionLabel != null)
//				questionLabel.UpdateQuestionLabel (question.Description);
//			if (buttonContainer != null && buttonContainer.Length > 0) {
//				int i = 0;
//				foreach(QuizButton qButton in buttonContainer){
//
//					qButton.UpdateButton(question.Answers[i]);
//					i++;
//				}
//				i=0;
//			}
//		}
//		public void UpdateButtonSprites(int correctChoice,int buttonIndex){
//			switch (correctChoice) {
//			case 1: // 1 for Correct Choice
//				buttonContainer[buttonIndex].SetCorrectChoiceState();
//				break;
//			case 2: // 2 for Wrong Choice
//				buttonContainer[buttonIndex].SetWrongChoiceState();
//				break;
//			case 0: // 0 for Default Choice
//				buttonContainer[buttonIndex].SetDefaultState();
//				break;
//			}
//		}
//		public void ResetButtonSprites(){
//			foreach (QuizButton qButton in buttonContainer) {
//				qButton.SetDefaultState();
//			}
//		}
//		public void DisabeUI(bool flag){
//			quizPanelCanvasGroup.blocksRaycasts = flag;
//		}
//		public void DisableButtons(bool flag){
//			foreach(Button b in buttonContainer){
//				b.enabled = !flag;
//			}
//		}
//		public void UpdateStarManager(int id,bool flag){
//			if (flag) {
//				starManager.SetStar (id);
//			} else {
//				starManager.UnsetStar(id);
//			}
//		}
//		#endregion
//	

	}

}