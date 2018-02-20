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
	public class MessElement : MonoBehaviour
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
		#endregion
		#region PROPERTY MEMBERS
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

		string Decription {
			get {
				return this.decription;
			}
			set {
				decription = value;
			}
		}

		Time Time {
			get {
				return this.time;
			}
			set {
				time = value;
			}
		}

		MessElementStatus Status {
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