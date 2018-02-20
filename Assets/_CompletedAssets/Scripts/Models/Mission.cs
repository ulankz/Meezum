using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public enum Status{
		STARTED,
		COMPLETED
	}
	public class Mission : MonoBehaviour
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
		int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}

		string Title {
			get {
				return this.title;
			}
			set {
				title = value;
			}
		}

		Status Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		}

		int EarnedScores {
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