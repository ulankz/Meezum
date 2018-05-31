using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;

namespace MeezumGame{
public class PlayerManager : MonoBehaviour {
		#region PRIVATE MEMBERS
		[SerializeField]
		private List<Player> players;
		[SerializeField]
		private Player currentPlayer;

		private string fileName = "/Resources/player_data_v01.xml";
		#endregion

		#region PUBLIC METHODS
		public Player LoadCurrentPlayer(){
			Player currentPlayer = null;

			foreach (Player pl in players) {
				if (pl.IsActive == true) {
					currentPlayer = pl;
					break;
				}
			}
			return currentPlayer;
		}

		public void LoadPlayersFromXml(string path){
			XmlDocument xmlDoc = new XmlDocument();
			xmlDoc.Load(Application.dataPath + path);
			foreach (XmlNode node in xmlDoc.DocumentElement) {
				int id = int.Parse(node.Attributes [0].InnerText);
				bool isActive = bool.Parse (node.Attributes [1].InnerText);
				string name = node.ChildNodes [0].InnerText;
				string ava = node.ChildNodes[1].InnerText;
				int score = int.Parse(node.ChildNodes[2].InnerText);
				Debug.Log ("User data: " +id.ToString()+" "+isActive.ToString()+" "+ name+" "+ ava+" "+ score.ToString());
				players.Add (new Player (id,isActive,name,ava,score));
			}
			Debug.Log ("User count: " + players.Count);
		}

		public void SavePlayersToXml(string path) {
			XmlDocument xmlDoc = new XmlDocument ();
			XmlNode rootNode = xmlDoc.CreateElement ("players");
			xmlDoc.AppendChild (rootNode);

			foreach (Player pl in players) {
				XmlNode playerNode = xmlDoc.CreateElement ("player");
				XmlAttribute id = xmlDoc.CreateAttribute ("id");
				XmlAttribute isActive = xmlDoc.CreateAttribute ("isActive");

				id.Value = pl.Id.ToString();
				playerNode.Attributes.Append (id);
				isActive.Value = pl.IsActive.ToString();
				playerNode.Attributes.Append (isActive);

				XmlNode nameNode = xmlDoc.CreateElement ("name");
				XmlNode avaNode = xmlDoc.CreateElement ("avatar");
				XmlNode scoreNode = xmlDoc.CreateElement ("score");

				nameNode.InnerText = pl.Name;
				avaNode.InnerText = pl.Avatar;
				scoreNode.InnerText = pl.Score.ToString();
				playerNode.AppendChild (nameNode);
				playerNode.AppendChild (avaNode);
				playerNode.AppendChild (scoreNode);

				rootNode.AppendChild (playerNode);
			}

			xmlDoc.Save (Application.dataPath + path);
		}

		public bool CreatePlayer(string name, string avatar, int score){
			// Check if the number of users do not exceeds maxNumOfPlayers=6
			// Check if the player with the same name exist
			// Generate id
			// Create a new player
			// Set the new player as active (set the previous player as inactive)

			int maxNumOfPlayers = 6;

			int numOfPlayers = players.Count;
			if (numOfPlayers >= maxNumOfPlayers) {
				Debug.Log ("Number of players has reached the maximum!");
				return false;
			} 

			foreach (Player pl in players) {
				if (pl.Name.Equals(name)) {
					Debug.Log ("A user with the same name exists!");
					return false;
				}
			}

			// Generate id
			int id = name.GetHashCode ();

			DeactivatePlayer ();

			bool isActive = true;
			Player player = new Player(id,isActive,name,avatar,score);
			currentPlayer = player;
			players.Add (player);
			Debug.Log ("New player has been added!");

			return true;
		}

		private void DeactivatePlayer() {
			// Mark an active player as inactive
			foreach(Player pl in players) {
				if (pl.Id==currentPlayer.Id){
					pl.IsActive=false;
					break;
				}
			}
		}

		private void ActivatePlayer(int id) {
			// Mark a player with the specified id as active
			foreach(Player pl in players) {
				if (pl.Id==id){
					pl.IsActive=true;
					LoadCurrentPlayer ();
					break;
				}
			}
		}

		public void ChoosePlayer(int id) {
			DeactivatePlayer ();
			ActivatePlayer (id);
		}

		public void UpdatePlayer(){

		}
		#endregion

		#region PROPERTY MEMBERS
		public List<Player> Players {
			get {
				return this.players;
			}
			set {
				players = value;
			}
		}

		Player CurrentPlayer {
			get {
				return this.currentPlayer;
			}
			set {
				currentPlayer = value;
			}
		}
		#endregion

		void Start() {
			players = new List<Player> ();
			LoadPlayersFromXml (fileName);
			//Debug.Log (players.Count);
			currentPlayer = LoadCurrentPlayer ();
		}

		void OnApplicationPause() {
			//Debug.Log ("OnPause"+players.Count);
			if (players.Count!=0)
				SavePlayersToXml (fileName);
		}

		void OnApplicationFocus() {
			//Debug.Log ("OnFocus");
			if (players.Count!=0)
				SavePlayersToXml (fileName);
		}

		void OnApplicationQuit() {
			//Debug.Log ("OnQuit");
			if (players.Count!=0)
				SavePlayersToXml (fileName);
		}
}
}