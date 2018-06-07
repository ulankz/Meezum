using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

#if UNITY_EDITOR
using UnityEditor;
#endif

namespace MeezumGame
{
	[Serializable]
	public class Player
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private int
			id;
		[SerializeField]
		private string
			name;
		[SerializeField]
		private string 
			avatar;
		//[SerializeField]
		//private int 
		//	age;
		[SerializeField]
		private int
			score;
		[SerializeField]
		private List<Mission>
			completedMissions;
		[SerializeField]
		private bool
			isActive;
		[SerializeField]
		private List<MessElement>
			disorder;
		[SerializeField]
		private Language
			language;
		[SerializeField]
		private int cleanedDisorders;
		#endregion
		#region CONSTRUCTORS
		public Player (int id, string name, string avatar, int score, List<Mission> completedMissions, bool isActive,int cleanedDisorders, List<MessElement> disorder, Language language)
		{
			this.id = id;
			this.name = name;
			this.avatar = avatar;
			this.score = score;
			this.completedMissions = completedMissions;
			this.isActive = isActive;
			this.cleanedDisorders = cleanedDisorders;
			this.disorder = disorder;
			this.language = language;
		}
		public Player (int id, string name,  string avatar, int score,bool isActive,int cleanedDisorders)
		{
			this.id = id;
			this.isActive = isActive;
			this.name = name;
			//this.age = age;
			this.avatar = avatar;
			this.score = score;
			this.cleanedDisorders = cleanedDisorders;
		}

		public Player(){
		
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

		public string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		public string Avatar {
			get {
				return this.avatar;
			}
			set {
				avatar = value;
			}
		}

		/*public int Age {
			get {
				return this.age;
			}
			set {
				age = value;
			}
		}
		*/

		public int Score {
			get {
				return this.score;
			}
			set {
				score = value;
			}
		}
		public int CleanedDisorders {
			get {
				return this.cleanedDisorders;
			}
			set {
				cleanedDisorders = value;
			}
		}
		public List<Mission> CompletedMissions {
			get {
				return this.completedMissions;
			}
			set {
				completedMissions = value;
			}
		}


		public bool IsActive {
			get {
				return this.isActive;
			}
			set {
				isActive = value;
			}
		}

		public List<MessElement> Disorder {
			get {
				return this.disorder;
			}
			set {
				disorder = value;
			}
		}

		public Language Language {
			get {
				return this.language;
			}
			set {
				language = value;
			}
		}
		#endregion
		#region PUBLIC METHODS
		public void UpdateCompletedMission(Mission mission){
			//Implementation goes here
		}
		#endregion
	}


}