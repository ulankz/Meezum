using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame
{
	public class MissionManager : MonoBehaviour
	{
		#region PRIVATE MEMBERS
		private List<DetailedMission> missions;
		private DetailedMission currentMission;
		#endregion

		#region PUBLIC METHODS
		public List<DetailedMission> LoadMissionsFromXML(string path){
			return new List<DetailedMission>();
		}
		public void StartMisison(int id){

		}
		public void StopMission(){

		}
		#endregion

		#region PROPERTY MEMBERS
		List<DetailedMission> Missions {
			get {
				return this.missions;
			}
			set {
				missions = value;
			}
		}

		DetailedMission CurrentMission {
			get {
				return this.currentMission;
			}
			set {
				currentMission = value;
			}

		}
		#endregion
	}
}
