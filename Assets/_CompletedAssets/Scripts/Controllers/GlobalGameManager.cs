using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeezumGame{
public class GlobalGameManager : MonoBehaviour {
		public static GlobalGameManager instance;

		#region PRIVATE MEMBERS
		[SerializeField]
		public PlayerManager playerManager;
		[SerializeField]
		public MissionManager missionManager;
		[SerializeField]
		public Stack<UIManagable> uiManagerStack;

		[SerializeField]
		public MainUiManager mainUiManager;

		private void Awake() {
			if (instance != null) {
				Destroy (gameObject);
			} else {
				instance = this;
				DontDestroyOnLoad (gameObject);
			}
			if (playerManager != null){
				if (PlayerPrefs.GetInt ("InitialSave", 0) == 0) {
					playerManager.SavePlayersToXmlInitial ();
					PlayerPrefs.SetInt ("InitialSave",1);
					print("INITIAL LOAD OF PLAYERS " + PlayerPrefs.GetInt ("InitialSave", 0));
				}
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
		void OnApplicationQuit() {
			playerManager.SaveCurrentGame ();
		}
}
}
