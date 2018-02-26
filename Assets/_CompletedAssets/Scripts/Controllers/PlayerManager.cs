using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeezumGame{
public class PlayerManager : MonoBehaviour {
		#region PRIVATE MEMBERS
		[SerializeField]
		private List<Player> players;
		[SerializeField]
		private Player currentPlayer;
		#endregion

		#region PUBLIC METHODS
		public Player LoadCurrentPlayerFromXML(string path){

			return new Player();
		}
		public List<Player> LoadPlayersFromXml(string path){

			return new List<Player> ();
		}
		public Player CreatePlayer(int id,string name, int age){
			return new Player (id,name,age);
		}
		public void UpdatePlayer(){

		}
		#endregion

		#region PROPERTY MEMBERS
		List<Player> Players {
			get {
				return this.players;
			}
			set {
				players = value;
			}
		}

		Player CurrentPlayer {
			get {
				return this.currentPlayer;
			}
			set {
				currentPlayer = value;
			}
		}
		#endregion

}
}