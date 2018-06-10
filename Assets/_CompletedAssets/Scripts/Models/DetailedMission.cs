using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Xml;
using System.Xml.Serialization;
using System.Xml.Linq;
using System.Linq;

namespace MeezumGame
{
	public class DetailedMission : Mission
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private int id;
		[SerializeField]
		private string name;
		[SerializeField]
		private List<GameObject> maze;
		[SerializeField]
		private List<Task> tasks;
		[SerializeField]
		private Vector3 currentPosition;
		[SerializeField]
		private int currentTaskId;
		[SerializeField]
		private int totalPossibleScores;
		#endregion

		#region CONSTRUCTOR METHODS
		public DetailedMission (int id, string name, List<GameObject> maze, List<Task> tasks, Vector3 currentPosition, int currentTaskId, int totalPossibleScores)
		{
			this.id = id;
			this.maze = maze;
			this.tasks = tasks;
			this.currentPosition = currentPosition;
			this.currentTaskId = currentTaskId;
			this.totalPossibleScores = totalPossibleScores;
		}
		#endregion

		#region PROPERTY METHODS
		public int Id {
			get { 
				return this.id;
			}
			set { 
				id = value;
			}
		}

		public string Name {
			get { 
				return this.name;
			}
			set { 
				name = value;
			}
		}

		public List<GameObject> Maze {
			get {
				return this.maze;
			}
			set {
				maze = value;
			}
		}

		public List<Task> Tasks {
			get {
				return this.tasks;
			}
			set {
				tasks = value;
			}
		}

		public Vector3 CurrentPosition {
			get {
				return this.currentPosition;
			}
			set { 
				currentPosition = value;
			}
		}

		public int CurrentTaskId {
			get {
				return this.currentTaskId;
			}
			set {
				currentTaskId = value;
			}
		}

		public int TotalPossibleScores {
			get {
				return this.totalPossibleScores;
			}
			set {
				totalPossibleScores = value;
			}
		}
		#endregion
	}
}