using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public enum MissionStatus{
		Started,
		Completed
	}
	public class Task : MonoBehaviour
	{
		#region PROTECTED MEMMBERS
		[SerializeField]
		protected int id;
		[SerializeField]
		protected string title;
		[SerializeField]
		protected string description;
		[SerializeField]
		protected int scores;
		[SerializeField]
		protected MissionStatus status;
		#endregion

		#region PUBLIC CONSTRUCTOR METHOD
		public Task (int id, string title, string description, int scores, MissionStatus status)
		{
			this.id = id;
			this.title = title;
			this.description = description;
			this.scores = scores;
			this.status = status;
		}
		#endregion

		#region PROPERTY MEMBERS

		#endregion
	}
}