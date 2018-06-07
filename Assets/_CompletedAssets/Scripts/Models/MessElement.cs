using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public enum MessElementStatus{
		Queued,
		Disclosed,
		Cleaned
	}
	[System.Serializable]
	public class MessElement
	{
		#region PROTECTED MEMBERS
		[SerializeField]
		protected int id;
		[SerializeField]
		protected string title;
		[SerializeField]
		protected string decription;
		[SerializeField]
		protected Time time;
		[SerializeField]
		protected MessElementStatus status;
		#endregion
		#region CONSTRUCTOR METHODS
		public MessElement (int id, string title, string decription, Time time, MessElementStatus status)
		{
			this.id = id;
			this.title = title;
			this.decription = decription;
			this.time = time;
			this.status = status;
		}
		public MessElement (int id, string title, MessElementStatus status)
		{
			this.id = id;
			this.title = title;
			this.status = status;
		}
		#endregion
		#region PROPERTY MEMBERS
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

		public string Decription {
			get {
				return this.decription;
			}
			set {
				decription = value;
			}
		}

		public Time Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		public MessElementStatus Status {
			get {
				return this.status;
			}
			set {
				status = value;
			}
		}
		#endregion
		
	}
}