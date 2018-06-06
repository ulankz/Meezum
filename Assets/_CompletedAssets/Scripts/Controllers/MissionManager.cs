using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.Xml;
using System.Xml.Serialization;
using System.IO;
using System.Xml.Linq;
using System.Linq;
using UnityEngine.SceneManagement;

namespace MeezumGame
{
	public class MissionManager : MonoBehaviour
	{

		#region PRIVATE MEMBERS
		private List<DetailedMission> missions;
		private DetailedMission currentMission;
		private XDocument xmlDoc;
		private IEnumerable<XElement> items;
		#endregion

		#region PUBLIC METHODS
		void Start() {
			LoadMissionsFromXML ("Assets/_CompletedAssets/Resources/XML Files/missions.xml");
		}

		public List<DetailedMission> LoadMissionsFromXML(string path){
			xmlDoc = XDocument.Load (path);
			items = xmlDoc.Descendants ("Mission").Elements ();
			if (items.Count () != 0) {
				missions = new List<DetailedMission> ();
			}
			foreach(XElement item in items) {
				int id = Int32.Parse (item.Parent.Element ("id").Value.Trim ());
				string name = item.Parent.Element ("name").Value.Trim ();
				List<GameObject> maze = new List<GameObject> ();
				if (item.Parent.Element ("maze").Elements().Count() != 0) {
					//maze = item.Parent.Element ("maze").Elements();
				}
				List<Task> tasks = new List<Task> ();
				if (item.Parent.Element ("tasks").Elements().Count() != 0) {
					//List<Task> tasks = item.Parent.Element ("tasks").Elements();
				}
				Vector3 currentPosition = new Vector3(0, 0, 0);
				if(item.Parent.Element ("currentPosition").Elements().Count() != 0) {
					//currentPosition = item.Parent.Element ("currentPosition").Value.Trim ();
				}
				int currentTaskId = Int32.Parse(item.Parent.Element ("currentTaskId").Value.Trim ());
				int totalPossibleScores = Int32.Parse (item.Parent.Element ("totalPossibleScores").Value.Trim ());
				missions.Add (new DetailedMission (id, name, maze, tasks, currentPosition, currentTaskId, totalPossibleScores));
			}
			return missions;
		}

		public void StartMisison(int id){
			currentMission = missions [id];
			SceneManager.LoadScene (Scenes.COMICS_SCENE);
		}

		public void StopMission(){

		}
		#endregion

		#region PROPERTY MEMBERS
		public List<DetailedMission> Missions {
			get {
				return this.missions;
			}
			set {
				missions = value;
			}
		}

		public DetailedMission CurrentMission {
			get {
				return this.currentMission;
			}
			set {
				currentMission = value;
			}

		}
		#endregion
	}
}
