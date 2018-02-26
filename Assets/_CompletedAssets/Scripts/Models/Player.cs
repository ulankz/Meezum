using System.Collections;
using System.Collections.Generic;
using UnityEngine;
#if UNITY_EDITOR
using UnityEditor;
#endif
namespace MeezumGame
{
	public class Player : MonoBehaviour
	{
		#region PRIVATE MEMEBERS
		[SerializeField]
		private int
			id;
		[SerializeField]
		private string
			name;
		[SerializeField]
		private int
			age;
		[SerializeField]
		private int
			scores;
		[SerializeField]
		private List<Mission>
			completedMissions;
		[SerializeField]
		private bool
			isActive;
		[SerializeField]
		private MessElement[]
			disorder;
		[SerializeField]
		private Language
			language;
		#endregion
		#region CONSTRUCTORS
		public Player (int id, string name, int age, int scores, List<Mission> completedMissions, bool isActive, MessElement[] disorder, Language language)
		{
			this.id = id;
			this.name = name;
			this.age = age;
			this.scores = scores;
			this.completedMissions = completedMissions;
			this.isActive = isActive;
			this.disorder = disorder;
			this.language = language;
		}
		public Player (int id, string name, int age)
		{
			this.id = id;
			this.name = name;
			this.age = age;
		}
		public Player(){
		
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

		string Name {
			get {
				return this.name;
			}
			set {
				name = value;
			}
		}

		int Age {
			get {
				return this.age;
			}
			set {
				age = value;
			}
		}

		int Scores {
			get {
				return this.scores;
			}
			set {
				scores = value;
			}
		}

		List<Mission> CompletedMissions {
			get {
				return this.completedMissions;
			}
			set {
				completedMissions = value;
			}
		}


		bool IsActive {
			get {
				return this.isActive;
			}
			set {
				isActive = value;
			}
		}

		MessElement[] Disorder {
			get {
				return this.disorder;
			}
			set {
				disorder = value;
			}
		}

		Language Language {
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