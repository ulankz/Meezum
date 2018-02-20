using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public class DetailedMission : Mission
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private Maze maze;
		[SerializeField]
		private List<Task> tasks;
		[SerializeField]
		private int currentTaskId;
		[SerializeField]
		private int totalPossibleScores;
		#endregion

		#region CONSTRUCTOR METHODS
		public DetailedMission (Maze maze, List<Task> tasks, int currentTaskId, int totalPossibleScores)
		{
			this.maze = maze;
			this.tasks = tasks;
			this.currentTaskId = currentTaskId;
			this.totalPossibleScores = totalPossibleScores;
		}
		
		#endregion
		#region PROPERTY METHODS
		Maze Maze {
			get {
				return this.maze;
			}
			set {
				maze = value;
			}
		}

		List<Task> Tasks {
			get {
				return this.tasks;
			}
			set {
				tasks = value;
			}
		}

		int CurrentTaskId {
			get {
				return this.currentTaskId;
			}
			set {
				currentTaskId = value;
			}
		}

		int TotalPossibleScores {
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