using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using Localization;
namespace MeezumGame{
public class GameEntryUIManager : MonoBehaviour,UIManagable {
		#region PRIVATE MEMBERS
		[SerializeField]
		private Button startButton;
		[SerializeField]
		private Button exitButton;
		[SerializeField]
		private Button settingsButton;
		private LocalizedText gameTitle;
		private LocalizedText description;
//		private Text startButtonText;
		#endregion

		#region SYSTEM FUNCTIONS
		private void Awake(){
			startButton = GameObject.FindGameObjectWithTag (Tags.MENU_START_BUTTON).GetComponent<Button>();
			exitButton = GameObject.FindGameObjectWithTag (Tags.MENU_EXIT_BUTTON).GetComponent<Button>();
			settingsButton = GameObject.FindGameObjectWithTag (Tags.MENU_SETTINGS_BUTTON).GetComponent<Button>();
			gameTitle = GameObject.FindGameObjectWithTag (Tags.GAME_ENTRY_TITLE).GetComponent<LocalizedText>();
			description = GameObject.FindGameObjectWithTag (Tags.GAME_ENTRY_DESCRIPTION).GetComponent<LocalizedText>();
//			startButtonText = GameObject.FindGameObjectWithTag (Tags.GAME_ENTRY_START_BUTTON_TEXT).GetComponent<Text>();
			populateFields ();
		}
		private void Start(){
			//Debug.Log ("GLOBAL miniGameIndex is "  + GlobalClass.miniGameToLoad);

			startButton.onClick.AddListener(delegate {
				StartButton();
		});
			exitButton.onClick.AddListener(delegate {
				ExitLevel();
			});
			settingsButton.onClick.AddListener(delegate {
				OpenSettings();
			});
			//populateFields ();

		}
		private void populateFields(){
			switch(GlobalClass.miniGameToLoad){
				case 1:	
				 gameTitle.key = Constants.GAME_ENTRY_VICTORINA_TITLE;
			 	 description.key = Constants.GAME_ENTRY_VICTORINA_DESC;
				break;
			}
		}
		private void OnDisable(){
			startButton.onClick.RemoveAllListeners ();
			exitButton.onClick.RemoveAllListeners ();
			settingsButton.onClick.RemoveAllListeners ();
		}
		#endregion
		#region PRIVATE FUNCTIONS
		private void StartButton(){
			Debug.Log ("START BUTTON WAS CLICKED");
			switch(GlobalClass.miniGameToLoad){
			case 1:
				SceneManager.LoadScene (Scenes.QUIZ_GAME_SCENE);
				break;
			case 2:
				SceneManager.LoadScene (Scenes.GAME_OF_WORDS_SCENE);
			break;
			case 3:
				SceneManager.LoadScene (Scenes.CLASSIFICATION_SCENE);
			break;
	}

		}
		private void ExitLevel(){
			Debug.Log ("EXIT BUTTON WAS CLICKED");
		}
		private void OpenSettings(){
			Debug.Log ("SETTINGS BUTTON WAS CLICKED");
		}
		#endregion
}
}
