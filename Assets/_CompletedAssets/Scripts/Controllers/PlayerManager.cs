using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.IO;
using System;
using System.ComponentModel;
namespace MeezumGame{
	public class PlayerManager : MonoBehaviour,INotifyPropertyChanged {
		#region PRIVATE MEMBERS
		[SerializeField]
		private List<Player> players;
		[SerializeField]
		private Player currentPlayer;
		private string fileName = "players_initial.xml";
		[SerializeField]
		private string path;
		//private string fileName = "player_data_working.xml";
		#endregion
		public delegate void OnLoadCompleteDelegate();
		public event OnLoadCompleteDelegate loadCompleteDelegate;
		#region PUBLIC METHODS
		public Player LoadCurrentPlayer(){
			Player currentPlayer = null;

			foreach (Player pl in Players) {
				if (pl.IsActive == true) {
					currentPlayer = pl;
					break;
				}
			}
			return currentPlayer;
		}

		public void LoadPlayersFromXml(){
			if (System.IO.File.Exists (getPath ())) {
				path = getPath ();


				// Create XML reader settings
				XmlReaderSettings settings = new XmlReaderSettings ();
				settings.IgnoreComments = true;                         // Exclude comments
				//settings.ProhibitDtd = false;                           
				//settings.ValidationType = ValidationType.DTD;           // Validation

				// Create reader based on settings
				XmlReader reader = XmlReader.Create (path, settings);

				XmlDocument xmlDoc = new XmlDocument ();
				xmlDoc.Load (reader);
				int id;
				bool isActive;
				string name;
				string ava;
				int score;
				List<Mission> completedMissions;
				int cleanedDisorders;
				List<MessElement> disorders;
				Language lang;
				foreach (XmlNode node in xmlDoc.DocumentElement) {
					id = int.Parse (node.Attributes [0].InnerText);
					isActive = bool.Parse (node.Attributes [1].InnerText);
					name = node.SelectSingleNode ("name").InnerText;
					ava = node.SelectSingleNode ("avatar").InnerText;
					score = int.Parse (node.SelectSingleNode ("score").InnerText);
					cleanedDisorders = int.Parse (node.SelectSingleNode ("cleanedDisorders").InnerText);
					lang = (Language)Enum.Parse (typeof(Language),node.SelectSingleNode ("lang").InnerText);
					//print (lang.ToString());
					completedMissions = new List<Mission> (node.SelectSingleNode ("cleanedDisorders").ChildNodes.Count);
					Mission mission;
					MessElement disorder;

					//Mission (int id, string title, string description, Status status, int earnedScores)
					foreach (XmlNode child in node.SelectSingleNode("completedMissions").ChildNodes) {

						mission = new Mission (int.Parse (child.SelectSingleNode ("id").InnerText),
							child.SelectSingleNode ("title").InnerText,
							child.SelectSingleNode ("description").InnerText,
							(Status)Enum.Parse (typeof(Status),child.SelectSingleNode ("status").InnerText),
							int.Parse (child.SelectSingleNode ("earnedScores").InnerText));

						completedMissions.Add (mission);

					}
					disorders = new List<MessElement> (node.SelectSingleNode ("disorders").ChildNodes.Count);
					foreach (XmlNode child in node.SelectSingleNode("disorders").ChildNodes) {
					
						disorder = new MessElement (int.Parse (child.SelectSingleNode ("id").InnerText),
							child.SelectSingleNode ("title").InnerText,
							(MessElementStatus)Enum.Parse (typeof(MessElementStatus), child.SelectSingleNode ("status").InnerText));
						disorders.Add (disorder);

					}
					//int id, string name, string avatar, int score, List<Mission> completedMissions, bool isActive,int cleanedDisorders, MessElement[] disorder, Language language
					//Debug.Log ("User data: " +id.ToString()+" "+isActive.ToString()+" "+ name+" "+ ava+" "+ score.ToString() + " " + cleanedDisorders);
					Players.Add (new Player (id, name, ava, score, completedMissions, isActive, cleanedDisorders, disorders, lang));
				}
				reader.Close ();
				Debug.Log ("User count: " + Players.Count);
				if (loadCompleteDelegate != null) {
					loadCompleteDelegate ();
					print ("INITIAL LOAD IS COMPLETED ");
				}
			}
		}

		public void SavePlayersToXmlInitial() {
			
			path = getPath ();

			if (PlayerPrefs.GetInt ("InitialSave", 0) == 0) {
				Players = GenerateInitialPlayerList ();
	
				Debug.Log("INITIAL SAVE " + PlayerPrefs.GetInt ("InitialSave", 0));
			}

			print ("DEFAULT SAVE METHOD ");
			XmlDocument xmlDoc = new XmlDocument ();
			XmlNode rootNode = xmlDoc.CreateElement ("players");
			xmlDoc.AppendChild (rootNode);

			foreach (Player pl in Players) {
				print ( "PLAYER NAME FROM SavePlayersToXML " +  pl.Name);
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
				XmlNode cleanedDisorders = xmlDoc.CreateElement ("cleanedDisorders");
				XmlNode langNode = xmlDoc.CreateElement ("lang");
				nameNode.InnerText = pl.Name;
				avaNode.InnerText = pl.Avatar;
				scoreNode.InnerText = pl.Score.ToString();
				cleanedDisorders.InnerText = pl.CleanedDisorders.ToString ();
				langNode.InnerText = pl.Language.ToString();
				playerNode.AppendChild (nameNode);
				playerNode.AppendChild (avaNode);
				playerNode.AppendChild (scoreNode);
				playerNode.AppendChild (cleanedDisorders);
				playerNode.AppendChild (langNode);


				XmlNode completedMissionsNode = xmlDoc.CreateElement ("completedMissions");
				foreach (Mission m in pl.CompletedMissions) {
					XmlNode missionNode = xmlDoc.CreateElement ("mission");
					XmlNode missionIdNode = xmlDoc.CreateElement ("id");
					XmlNode missionTitleNode = xmlDoc.CreateElement ("title");
					XmlNode missionDescNode = xmlDoc.CreateElement ("description");
					XmlNode missionStatusNode = xmlDoc.CreateElement ("status");
					XmlNode missionEarnedScoresNode = xmlDoc.CreateElement ("earnedScores");

					missionIdNode.InnerText = m.Id.ToString();
					missionTitleNode.InnerText = m.Title;
					missionDescNode.InnerText = m.Description;
					missionStatusNode.InnerText = m.Status.ToString();
					missionEarnedScoresNode.InnerText = m.EarnedScores.ToString();
					missionNode.AppendChild (missionIdNode);
					missionNode.AppendChild (missionTitleNode);
					missionNode.AppendChild (missionDescNode);
					missionNode.AppendChild (missionStatusNode);
					missionNode.AppendChild (missionEarnedScoresNode);
					completedMissionsNode.AppendChild (missionNode);
				}
				playerNode.AppendChild (completedMissionsNode);
				XmlNode disordersNode = xmlDoc.CreateElement ("disorders");
				foreach(MessElement m in pl.Disorder){
					XmlNode disorderNode = xmlDoc.CreateElement ("disorder");
					XmlNode dIdNode = xmlDoc.CreateElement ("id");
					XmlNode dTitleNode = xmlDoc.CreateElement ("title");
					XmlNode dStatusNode = xmlDoc.CreateElement ("status");
					dIdNode.InnerText = m.Id.ToString ();
					dTitleNode.InnerText = m.Title;
					dStatusNode.InnerText = m.Status.ToString();
					disorderNode.AppendChild (dIdNode);
					disorderNode.AppendChild (dTitleNode);
					disorderNode.AppendChild (dStatusNode);
					disordersNode.AppendChild (disorderNode);
				}
				playerNode.AppendChild (disordersNode);
				rootNode.AppendChild (playerNode);
			}

			xmlDoc.Save (path);
			PlayerPrefs.SetInt ("InitialSave",1);
		}

		public void SavePlayersToXml() {
			SavePlayersToXmlInitial ();
			/*path = getPath ();

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

				XmlNode cleanedDisorders = xmlDoc.CreateElement ("cleanedDisorders");

				nameNode.InnerText = pl.Name;
				avaNode.InnerText = pl.Avatar;
				scoreNode.InnerText = pl.Score.ToString();
				cleanedDisorders.InnerText = pl.CleanedDisorders.ToString ();
				playerNode.AppendChild (nameNode);
				playerNode.AppendChild (avaNode);
				playerNode.AppendChild (scoreNode);
				playerNode.AppendChild (cleanedDisorders);
				rootNode.AppendChild (playerNode);
			}

			xmlDoc.Save (path);
			*/
		}
		private List<Player> GenerateInitialPlayerList(){
			List<Player> players = new List<Player> ();
			int id = -1994117179;
			string name = "Aruna";
			string ava = "rhon";
			bool isActive = true;
			players.Add (GenerateDefaultAttributesForNewPlayer(id,name,ava,isActive));
			print ("INITIAL PLAYER LIST IS GENERATED WITH " + players.Count);
			return players;
		}
		private Player GenerateDefaultAttributesForNewPlayer(int id,string name,string ava,bool isActive){
			Player p = new Player (id,name,ava,isActive);
			List<Mission> completedMissions = new List<Mission> ();
			int mId = 0;
			string title = "Supermarket";
			string description = "First mission to play";
			Status mStatus = Status.NONE;
			int earnedScores = 0;
			Mission m = new Mission (mId, title, description, mStatus, earnedScores);
			completedMissions.Add (m);
			int cleanedDisorders = 3;
			Language lang = Language.RU;
			List<MessElement> disorders = new List<MessElement> ();
			disorders.Add(new MessElement(0,"mess_toycar",MessElementStatus.Cleaned));
			disorders.Add(new MessElement(1,"mess_redpillow",MessElementStatus.Cleaned));
			disorders.Add(new MessElement(2,"mess_rabbit",MessElementStatus.Cleaned));
			disorders.Add(new MessElement(3,"mess_blanket",MessElementStatus.Disclosed));
			disorders.Add(new MessElement(4,"mess_yellowpillow",MessElementStatus.Queued));
			disorders.Add(new MessElement(5,"mess_pinkpillow",MessElementStatus.Queued));
			disorders.Add(new MessElement(6,"mess_bear",MessElementStatus.Queued));
			disorders.Add(new MessElement(7,"mess_pencils",MessElementStatus.Queued));
			disorders.Add(new MessElement(8,"mess_vase",MessElementStatus.Queued));
			disorders.Add(new MessElement(9,"mess_cw_00",MessElementStatus.Queued));
			disorders.Add(new MessElement(10,"mess_cw_02",MessElementStatus.Queued));
			disorders.Add(new MessElement(11,"mess_cw_04",MessElementStatus.Queued));
			disorders.Add(new MessElement(12,"mess_cw_06",MessElementStatus.Queued));
			disorders.Add(new MessElement(13,"mess_cw_10",MessElementStatus.Queued));
			disorders.Add(new MessElement(14,"mess_cw_11",MessElementStatus.Queued));
			disorders.Add(new MessElement(15,"mess_cw_12",MessElementStatus.Queued));
			disorders.Add(new MessElement(16,"mess_cw_14",MessElementStatus.Queued));
			disorders.Add(new MessElement(17,"mess_cup",MessElementStatus.Queued));
			disorders.Add(new MessElement(18,"mess_blotch_window_top",MessElementStatus.Queued));
			disorders.Add(new MessElement(19,"mess_blotch_window_right_bottom",MessElementStatus.Queued));
			disorders.Add(new MessElement(20,"mess_ink",MessElementStatus.Queued));
			disorders.Add(new MessElement(21,"mess_blotch_leftwall",MessElementStatus.Queued));
			disorders.Add(new MessElement(22,"mess_blotch_rightwall",MessElementStatus.Queued));
			disorders.Add(new MessElement(23,"mess_scarf",MessElementStatus.Queued));
			disorders.Add(new MessElement(24,"mess_spidernet_shelves_top",MessElementStatus.Queued));
			disorders.Add(new MessElement(25,"mess_spidernet_portrets",MessElementStatus.Queued));
			disorders.Add(new MessElement(26,"mess_spidernet_sofa",MessElementStatus.Queued));


			//Player p = new Player (id, name, ava, score, completedMissions, isActive, cleanedDisorders, disorders, lang);
			p.Score = 0;
			p.CompletedMissions = completedMissions;
			p.IsActive = isActive;
			p.CleanedDisorders = cleanedDisorders;
			p.Disorder = disorders;
			p.Language = lang;

			return p;
		}
		public bool CreatePlayer(string name, string avatar, int score){
			// Check if the number of users do not exceeds maxNumOfPlayers=6
			// Check if the player with the same name exist
			// Generate id
			// Create a new player
			// Set the new player as active (set the previous player as inactive)

			int maxNumOfPlayers = 6;

			int numOfPlayers = Players.Count;
			if (numOfPlayers >= maxNumOfPlayers) {
				Debug.Log ("Number of players has reached the maximum!");
				return false;
			} 

			foreach (Player pl in Players) {
				if (pl.Name.Equals(name)) {
					Debug.Log ("A user with the same name exists!");
					return false;
				}
			}

			// Generate id
			int id = name.GetHashCode ();

			DeactivatePlayer ();

			bool isActive = true;
			//int id, string name,  string avatar, int score,bool isActive,int cleanedDisorders
			Player player = GenerateDefaultAttributesForNewPlayer(id,name,avatar,isActive);//new Player(id,name,avatar,isActive);
			currentPlayer = player;
			Players.Add (player);
			Debug.Log ("New player has been added!");
			//SaveCurrentGame ();
			return true;
		}

		private void DeactivatePlayer() {
			// Mark an active player as inactive
			foreach(Player pl in Players) {
				if (pl.Id==currentPlayer.Id){
					pl.IsActive=false;
					break;
				}
			}
		}

		private void ActivatePlayer(int id) {
			// Mark a player with the specified id as active
			foreach(Player pl in Players) {
				if (pl.Id==id){
					pl.IsActive=true;
					CurrentPlayer = LoadCurrentPlayer ();
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

		public Player CurrentPlayer {
			get {
				return this.currentPlayer;
			}
			set {
				currentPlayer = value;
			}
		}
		#endregion

		void Start() {
			Players = new List<Player> ();
			//SavePlayersToXmlInitial ();
			if (PlayerPrefs.GetInt ("InitialSave", 0) == 1) {
				LoadPlayersFromXml ();
				print("GAME IS INITIALLY SAVED AND WE START TO LOAD");
			//Debug.Log (players.Count);
			//currentPlayer = LoadCurrentPlayer ();
			}
		}

		void OnApplicationPause() {
			//Debug.Log ("OnPause"+players.Count);
			//if (players.Count!=0)
				///SavePlayersToXml ();
		}

		void OnApplicationFocus() {
			//Debug.Log ("OnFocus");
			//if (players.Count!=0)
				//SavePlayersToXml ();
		}

		void OnApplicationQuit() {
			//Debug.Log ("OnQuit");
			//if (players.Count!=0)
				//SavePlayersToXml ();
		}
		public void SaveCurrentGame(){
			if (Players.Count!=0)
			    SavePlayersToXml ();
		}
		public string getPath(){
			#if UNITY_EDITOR
			return Application.dataPath +"/Resources/"+fileName;
			#elif UNITY_ANDROID
			return Application.persistentDataPath+fileName;
			#elif UNITY_IPHONE
			return Application.persistentDataPath+"/"+fileName;
			#else
			return Application.dataPath +"/"+ fileName;
			#endif
			 }
		void OnEnable(){
			loadCompleteDelegate += OnLoadCompletedHandler;			
		}
		void OnDisable(){
			loadCompleteDelegate -= OnLoadCompletedHandler;
		}
		private void OnLoadCompletedHandler(){
			currentPlayer = LoadCurrentPlayer();
		}
			public event PropertyChangedEventHandler PropertyChanged;
			private void NotifyChanged(PropertyChangedEventArgs e){
			if (PropertyChanged != null)
				PropertyChanged (this,e);
			}
			private static PropertyChangedEventArgs playerArgs = new PropertyChangedEventArgs ("Players");
			public List<Player> Players{
			get{ 
				return this.players;
			}
			set{ 
				this.players = value;
				NotifyChanged (playerArgs);
			}
			}
}
}