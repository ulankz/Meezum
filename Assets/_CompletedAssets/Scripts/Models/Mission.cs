using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public enum Status{
		NONE,
		STARTED,
		COMPLETED

	}
	[System.Serializable]
	public class Mission
	{
		#region PROTECTED MEMEBERS
		[SerializeField]
		protected int id;
		[SerializeField]
		protected string title;
		[SerializeField]
		protected string description;
		[SerializeField]
		protected Status status;
		[SerializeField]
		protected int earnedScores;
		#endregion
		#region PPROPERTY MEMBERS
		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		public string Title {
			get {
				return this.title;
			}
			set {
				title = value;
			}
		}
		public string Description {
			get {
				return this.description;
			}
			set {
				description = value;
			}
		}
		public Status Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		}

		public int EarnedScores {
			get {
				return this.earnedScores;
			}
			set {
				earnedScores = value;
			}
		}
		#endregion
		#region CONSTRUCTOR METHODS
		public Mission (int id, string title, string description, Status status, int earnedScores)
		{
			this.id = id;
			this.title = title;
			this.description = description;
			this.status = status;
			this.earnedScores = earnedScores;
		}
		public Mission(){

		}
		#endregion

		#region PUBLIC METHODS

		#endregion
	}

}