using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace MeezumGame{
public class ComicsUIManager : MonoBehaviour,UIManagable {
		/*#region PRIVATE MEMBERS
		[SerializeField]
		private Button startButton;

		private GlobalGameManager game;
		private MissionManager missionManager;
		#endregion

		#region SYSTEM FUNCTIONS
		private void Awake(){
			startButton = GameObject.FindGameObjectWithTag (Tags.COMICS_START_BUTTON).GetComponent<Button>();
		}
		private void Start(){
			startButton.onClick.AddListener(delegate {
				StartButton();
			});
			game = GlobalGameManager.instance;
			missionManager = game.Mission_Manager;
		}
		private void OnDisable(){
			startButton.onClick.RemoveAllListeners ();
		}
		#endregion
		#region PRIVATE FUNCTIONS
		private void StartButton(){
			Debug.Log ("START BUTTON WAS CLICKED");
			switch (missionManager.CurrentMission.Id) {
				case 0: // Mission 1
				case 1: // Mission 2
				case 2: // Mission 3
				SceneManager.LoadScene (Scenes.MAZE_SCENE);		
				break;
			}
		}
		#endregion*/
}
}
