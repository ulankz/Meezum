using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GameOfWords
{
	public class Cell : MonoBehaviour
	{
	#region PRIVATE MEMBERS
		[SerializeField]
		private  int
			cellIndex = 0;
	#endregion
	#region PUBLIC METHODS
	#endregion
	#region PRIVATE METHODS
	#endregion
	#region PROPERTIY MEMBERS
		public int CellIndex {
			get {
				return this.cellIndex;
			}
			set {
				cellIndex = value;
			}
		}
	#endregion
	#region SYSTEM METHODS
		void Start ()
		{
			cellIndex = int.Parse (gameObject.name.Substring (5));
		}
	#endregion
	#region PRIVATE METHODS
	
	#endregion
	}
}
