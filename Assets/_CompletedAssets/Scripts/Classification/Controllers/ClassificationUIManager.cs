using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
using System;
using System.Linq;
namespace Classification
{
	public class ClassificationUIManager : MonoBehaviour, UIManagable
	{

		#region PRIVATE MEMBERS
		[SerializeField]
		private GameObject gameWordsRootPanel;
		[SerializeField]
		private CanvasGroup gameWordsPanelCanvasGroup;
		[SerializeField]
		private Image character;
		[SerializeField]
		private GameObject gamePanel;
		[SerializeField] 
		private GameObject questionPanel;
		[SerializeField] 
		private GameObject actorsPanel;
		[SerializeField] 
		private Actor[] actorsContainer;

		[SerializeField]
		private StarManager starManager;
		[SerializeField]
		private ClassificationQuestionLabel questionLabel;
		//[SerializeField]
		//private CellPlaceHolder cellsContainer;
		[SerializeField]
		private Button checkButton;
		[SerializeField]
		private List<Sprite> actorSprites;
		private string actorSpritePath = "Classification";
		#endregion
//
//		#region DELEGATE AND EVENTS
//		public delegate void OnButtonSingleClickDelegate (string id);
//		public static event OnButtonSingleClickDelegate buttonSingleClickDelegate;
//		public delegate void OnButtonDoubleClickDelegate (string id);
//		public static event OnButtonDoubleClickDelegate buttonDoubleClickDelegate;
//
//		#endregion
//
		#region PUBLIC PROPERTIES
		public Actor[] ActorsContainer {
			get {
				return this.actorsContainer;
			}
			set {
				actorsContainer = value;
			}
		}
		#endregion
		#region SYSTEM METHODS
		void Awake(){
			transform.tag = Tags.CLASSIFICATION_UI_MANAGER;
			LoadActorSprites (actorSpritePath);
			Debug.Log ("ACTOR SPRITES LOADED IN CLASSIFICATION UI MANAGER");
			gameWordsRootPanel = GameObject.FindGameObjectWithTag (Tags.CLASSIFICATION_ROOT_PANEL);
			gamePanel = GameObject.FindGameObjectWithTag (Tags.CLASSIFICATION_GAME_PANEL);
			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER).GetComponent<StarManager>();
			if (gamePanel != null) {
				questionPanel = GameObject.FindGameObjectWithTag(Tags.CLASSIFICATION_QUESTION_PANEL);
				questionLabel = questionPanel.GetComponentInChildren<ClassificationQuestionLabel>();
				actorsPanel = GameObject.FindGameObjectWithTag(Tags.CLASSIFICATION_ACTORS_PANEL);
				actorsContainer = actorsPanel.GetComponentsInChildren<Actor>(); //GameObject.FindGameObjectsWithTag(Tags.CLASSIFICATION_ACTOR).OrderBy (g => g.name).ToArray ();
				checkButton = GameObject.FindGameObjectWithTag(Tags.CLASSIFICATION_CHECK_BUTTON).GetComponent<Button>();

			}
			if (gameWordsRootPanel != null) {
				gameWordsPanelCanvasGroup = gameWordsRootPanel.GetComponent<CanvasGroup>(); 
			}


		}

		#endregion

//		public void buttonDoubleClickHandler(string id){
//			if (buttonDoubleClickDelegate != null) {
//				buttonDoubleClickDelegate(id);
//			}
//		}
//		
		#region PRIVATE METHODS
		private List<Sprite> LoadActorSprites(string path){
			actorSprites = (Resources.LoadAll<Sprite> (path)).ToList();
			if (actorSprites.Count > 0) {
				Debug.Log ("SPRITE LOADING COMPLETED SUCCESSFULLY");
				return actorSprites;
			}
			return null;
		}
		#endregion
		#region PUBLIC METHODS
		public void PopulateUI(ClassificationQuestion question){
			if (questionLabel != null) {
				questionLabel.UpdateQuestionLabel (question.Description);
		}
			if (actorsContainer != null && actorsContainer.Length > 0) {
				foreach(Actor actor in actorsContainer){
					Debug.Log("Question " + actorSprites);
					actor.UpdateActor(question,actorSprites);
				}
			}
		}
		public void UpdateActorSprites(int correctChoice,int spriteIndex){
			switch (correctChoice) {
			case 1: // 1 for Correct Choice
				actorsContainer[spriteIndex].SetCorrectChoiceState();
				break;
			case 2: // 2 for Wrong Choice
				actorsContainer[spriteIndex].SetWrongChoiceState();
				break;
			case 0: // 0 for Default Choice
				actorsContainer[spriteIndex].SetDefaultState();
				break;
			}
		}
		public void UpdateActorSprites(){
			foreach(Actor a in actorsContainer){
				a.SetDefaultState();
			}
		}
		public void ResetCheckButton(){
			checkButton.image.color = Color.white;
		}
		public void DisabeUI(bool flag){
			gameWordsPanelCanvasGroup.blocksRaycasts = flag;
		}
		public void DisableButtons(bool flag){
			if(checkButton!=null)
				checkButton.interactable = !flag;
		}
		public void UpdateStarManager(int id,bool flag){
			if (flag) {
				starManager.SetStar (id);
			} else {
				starManager.UnsetStar(id);
			}
		}
	#endregion
	}

}