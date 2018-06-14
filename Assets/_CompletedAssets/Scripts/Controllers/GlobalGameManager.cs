using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Localization;
using System.Linq;
using System;
using UnityEngine.SceneManagement;
namespace MeezumGame{
public class GlobalGameManager : MonoBehaviour {

		private static GlobalGameManager m_instance = null;

		private GlobalGameManager()
		{
		}

		public static GlobalGameManager instance
		{
			get
			{ 
				if (m_instance == null) 
				{
					m_instance = new GlobalGameManager ();
				}
				return m_instance;
			}
		}

		#region PRIVATE MEMBERS
		[SerializeField]
		public PlayerManager playerManager;
		[SerializeField]
		public MissionManager missionManager;
		[SerializeField]
		public Stack<UIManagable> uiManagerStack;

		[SerializeField]
		public MainUiManager mainUiManager;

		[SerializeField]
		private LocalizationManager localizationManager;

		[SerializeField]
		private GameDurationTimerManager gameDurationTimerManager;

		private void Awake() {
			if (m_instance != null) {
				Destroy (gameObject);
			} else {
				m_instance = this;
				DontDestroyOnLoad (gameObject);
			}
			if (playerManager != null){
				if (PlayerPrefs.GetInt ("InitialSave", 0) == 0) {
					playerManager.SavePlayersToXmlInitial ();
					print("INITIAL LOAD OF PLAYERS " + PlayerPrefs.GetInt ("InitialSave", 0));
				}
			}
		}

		public PlayerManager Player_Manager {
			get { 
				return this.playerManager;
			}
			set { 
				playerManager = value;
			}
		}

		public MissionManager Mission_Manager {
			get { 
				return this.missionManager;
			}
			set { 
				missionManager = value;
			}
		}

		public MainUiManager Main_UI_Manager {
			get { 
				return this.mainUiManager;
			}
			set { 
				mainUiManager = value;
			}
		}

		public LocalizationManager Localization_Manager {
			get { 
				return this.localizationManager;
			}
			set { 
				localizationManager = value;
			}
		}

		public GameDurationTimerManager Game_Duration_Timer_Manager {
			get { 
				return this.gameDurationTimerManager;
			}
			set { 
				gameDurationTimerManager = value;
			}
		}

		void OnEnable() {
			MainUiManager.OnRegOkClickEvent += CreateNewPlayer;
			MainUiManager.OnChooseClickEvent += GetListOfPlayerInfo;
			MainUiManager.OnChangeCurrentUsersClickEvent+=ChangeCurrentUser;
		}

		void OnDisable() {
			MainUiManager.OnRegOkClickEvent -= CreateNewPlayer;
			MainUiManager.OnChooseClickEvent -= GetListOfPlayerInfo;
			MainUiManager.OnChangeCurrentUsersClickEvent-=ChangeCurrentUser;
		}

		void CreateNewPlayer(string name, string ava) {
			Debug.Log ("New player has been created\nName: "+name + " ava: "+ava);

			playerManager.CreatePlayer (name, ava, 0);
		}
		private void ChangeCurrentUser(Int32 id){
			playerManager.ChoosePlayer (id);
			Debug.Log ("PLAYER IS CHANGED TO " + id);
		}

		List<Player> GetListOfPlayerInfo() {
			//List<Player> plInfo = new List<Player> ();
			//foreach (Player pl in playerManager.Players) {
				//plInfo.Add (pl.Id + " " + pl.Name + " " + pl.Avatar);
				//print (pl.Id + " " + pl.Name + " " + pl.Avatar);
			//}

			return playerManager.Players;
		}
			
		#endregion
		void OnApplicationQuit() {
			playerManager.SaveCurrentGame ();
		}
		private void PlayerListChangedHandler(object sender,System.ComponentModel.PropertyChangedEventArgs e){
			print ("PLAYER LIST IS CHANGED " + e.PropertyName);
	
		}
}
}
