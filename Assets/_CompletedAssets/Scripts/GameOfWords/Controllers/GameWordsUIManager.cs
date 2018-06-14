using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
namespace GameOfWords
{
	public class GameWordsUIManager : MonoBehaviour, UIManagable
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
		private StarManager starManager;
		[SerializeField]
		private CellPlaceHolder cellsContainer;
		[SerializeField]
		private Button checkButton;
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
		#region SYSTEM METHODS
		void Awake(){
			gameWordsRootPanel = GameObject.FindGameObjectWithTag (Tags.GAME_WORDS_ROOT_PANEL);
			gamePanel = GameObject.FindGameObjectWithTag (Tags.GAME_PANEL);
			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER).GetComponent<StarManager>();
			if (gamePanel != null) {
				questionPanel = GameObject.FindGameObjectWithTag(Tags.QUESTIONS_PANEL);
				cellsContainer = GameObject.FindGameObjectWithTag(Tags.CELLS).GetComponent<CellPlaceHolder>();
				character = GameObject.FindGameObjectWithTag(Tags.CHARACTER).GetComponent<Image>();
				checkButton = GameObject.FindGameObjectWithTag(Tags.CHECK_BUTTON).GetComponent<Button>();
			}
			if (gameWordsRootPanel != null) {
				gameWordsPanelCanvasGroup = gameWordsRootPanel.GetComponent<CanvasGroup>(); 
			}
		}
		void Update(){

		}
		void OnEnable(){
			ActivatePanel.onUIStateChanged += OnUIStateChangedhandler;
		}
		void OnDisable(){
			ActivatePanel.onUIStateChanged -= OnUIStateChangedhandler;
		}
		#endregion

		private void OnUIStateChangedhandler(bool open){
			if (open) {
				questionPanel.SetActive (false);
				cellsContainer.gameObject.SetActive(false);
			} else {
				questionPanel.SetActive (true);
				cellsContainer.gameObject.SetActive(true);
			}
		}
//		public void buttonDoubleClickHandler(string id){
//			if (buttonDoubleClickDelegate != null) {
//				buttonDoubleClickDelegate(id);
//			}
//		}
//
		#region PUBLIC METHODS
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
		public void UpdateButtonSprites(CellStatus status){
			switch (status) {
			case CellStatus.EMPTY: // 1 for Correct Choice
				checkButton.interactable = false;
				checkButton.image.color = Color.white;
				break;
			case CellStatus.PARTIALY_FILLED: // 2 for Wrong Choice
				checkButton.interactable = true;
				checkButton.image.color = Color.yellow;
				break;
			case CellStatus.FULLY_FILLED: // 0 for Default Choice
				checkButton.interactable = true;
				checkButton.image.color = Color.green;
				break;
			}

		}
		public void UpdateTiles(bool flag){
			if (flag) {
				foreach (Tile t in cellsContainer.ActiveTiles) {
					t.gameObject.GetComponent<SpriteRenderer> ().color = Color.green;
				}
			}
				else{
					foreach(Tile t in cellsContainer.ActiveTiles){
						t.gameObject.GetComponent<SpriteRenderer>().color = Color.red;
					}
				}

		}
		public void ResetTileColors(){
			foreach (Tile t in cellsContainer.ActiveTiles) {
				t.gameObject.GetComponent<SpriteRenderer> ().color = Color.white;
			}
		}
		public void ResetTilePositions(){
			foreach(Tile t in cellsContainer.ActiveTiles){
				Debug.Log("ACTIVE TILES AFTER RESET " + t);
				t.PutToInitialPlace();

			}
			cellsContainer.ActiveTiles.Clear ();
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
		public void SetupActiveCells(int levelComplexity){
			cellsContainer.LookUpCurrentActiveCells (levelComplexity);
		}
		#endregion
		public CellStatus GetCellStatus(){
			return cellsContainer.CellStatus;
		}

	}

}