using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MeezumGame{
public class ComicsUIManager : MonoBehaviour,UIManagable {
		#region PRIVATE MEMBERS
		[SerializeField]
		private Button startButton;
		[SerializeField]
		private Button exitButton;
		[SerializeField]
		private Button settingsButton;
		#endregion

		#region SYSTEM FUNCTIONS
		private void Awake(){
			startButton = GameObject.FindGameObjectWithTag (Tags.COMICS_START_BUTTON).GetComponent<Button>();
			exitButton = GameObject.FindGameObjectWithTag (Tags.COMICS_EXIT_BUTTON).GetComponent<Button>();
			settingsButton = GameObject.FindGameObjectWithTag (Tags.COMICS_SETTINGS_BUTTON).GetComponent<Button>();
		}
		private void Start(){
			startButton.onClick.AddListener(delegate {
				StartButton();
		});
			exitButton.onClick.AddListener(delegate {
				ExitLevel();
			});
			settingsButton.onClick.AddListener(delegate {
				OpenSettings();
			});

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
			GlobalClass.miniGameToLoad = 1;
			SceneManager.LoadScene (Scenes.GAME_ENTRY_SCENE);
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
