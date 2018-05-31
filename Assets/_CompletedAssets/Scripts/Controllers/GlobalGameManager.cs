using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeezumGame{
public class GlobalGameManager : MonoBehaviour {
		private static GlobalGameManager instance;

		#region PRIVATE MEMBERS
		[SerializeField]
		private PlayerManager playerManager;
		[SerializeField]
		private MissionManager missionManager;
		[SerializeField]
		private Stack<UIManagable> uiManagerStack;

		[SerializeField]
		private MainUiManager mainUiManager;

		private void Awake() {
			if (instance != null) {
				Destroy (gameObject);
			} else {
				instance = this;
				DontDestroyOnLoad (gameObject);
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
