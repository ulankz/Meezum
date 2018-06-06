using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Localization;

namespace MeezumGame{
public class GlobalGameManager : MonoBehaviour {
		private static GlobalGameManager instance = null;

		private GlobalGameManager()
		{
		
		}

		public static GlobalGameManager Instance
		{
			get
			{ 
				if (instance == null) 
				{
					instance = new GlobalGameManager ();
				}
				return instance;
			}
		}

		#region PRIVATE MEMBERS
		[SerializeField]
		private PlayerManager playerManager;
		[SerializeField]
		private MissionManager missionManager;
		[SerializeField]
		private Stack<UIManagable> uiManagerStack;

		[SerializeField]
		private MainUiManager mainUiManager;

		[SerializeField]
		private LocalizationManager localizationManager;

		private void Awake() {
			if (instance != null) {
				Destroy (gameObject);
			} else {
				instance = this;
				DontDestroyOnLoad (gameObject);
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

		void OnEnable() {
			MainUiManager.OnRegOkClickEvent += CreateNewPlayer;
			MainUiManager.OnChooseClickEvent += GetListOfPlayerInfo;
		}

		void OnDesable() {
			MainUiManager.OnRegOkClickEvent -= CreateNewPlayer;
			MainUiManager.OnChooseClickEvent -= GetListOfPlayerInfo;
		}

		void CreateNewPlayer(string name, string ava) {
			Debug.Log ("New player has been created\nName: "+name + " ava: "+ava);

			playerManager.CreatePlayer (name, ava, 0);
		}

		List<string> GetListOfPlayerInfo() {
			List<string> plInfo = new List<string> ();
			foreach (Player pl in playerManager.Players) {
				plInfo.Add (pl.Id + " " + pl.Name + " " + pl.Avatar);
			}

			return plInfo;
		}
			
		#endregion


}
}
