using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{

	public class Maze : MonoBehaviour
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private Complexity complexity;
		[SerializeField]
		private Vector2 currentPosition;
		[SerializeField]
		private Vector2 entrance;
		[SerializeField]
		private Vector2 exit;
		private Matrix4x4 grid;
		#endregion

		#region PUBLIC MEMBERS
		public void GenerateNameMaze(int age){

		}
		public void LoadMazeFromTxt(string path)
		{

		}
		public bool isEndOfMaze(){
			return false;
		}
		#endregion

		#region PROPERTY MEMBERS
		Complexity Complexity {
			get {
				return this.complexity;
			}
			set {
				complexity = value;
			}
		}

		Vector2 CurrentPosition {
			get {
				return this.currentPosition;
			}
			set {
				currentPosition = value;
			}
		}

		Vector2 Entrance {
			get {
				return this.entrance;
			}
			set {
				entrance = value;
			}
		}

		Vector2 Exit {
			get {
				return this.exit;
			}
			set {
				exit = value;
			}
		}

		Matrix4x4 Grid {
			get {
				return this.grid;
			}
			set {
				grid = value;
			}
		}
		#endregion
	}
}