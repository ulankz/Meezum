using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using MeezumGame;

namespace GameOfWords
{
	public class CellPlaceHolder:MonoBehaviour
	{
	#region DELEGATES
		public delegate void OnCellStatusChangeDelegate(CellStatus status);
		public static event OnCellStatusChangeDelegate onCellStatusChangeDelegate;
	#endregion
	#region PRIVATE MEMBERS
	
		[SerializeField]
		private List<Cell>
			placeHolderCells;
		[SerializeField]
		private List<Cell>
			activeCells = new List<Cell> ();
		[SerializeField]
		private int filledCellCounter = 0;
		[SerializeField]
		private  List<Tile> activeTiles = new List<Tile>();
		[SerializeField]
		private CellStatus cellStatus;
	#endregion
	#region PUBLIC PROPERIES
		public List<Cell> PlaceHolderCells {
			get {
				return this.placeHolderCells;
			}
			set {
				placeHolderCells = value;
			}
		}
		public List<Cell> ActiveCells {
			get {
				return this.activeCells;
			}
			set {
				activeCells = value;
			}
		}
		public List<Tile> ActiveTiles {
			get {
				return this.activeTiles;
			}
			set {
				activeTiles = value;
			}
		}
		public CellStatus CellStatus {
			get {
				return this.cellStatus;
			}

		}
		int FilledCellCounter {
			get {
				return ActiveTiles.Count;
			}
		}
	#endregion
	#region SYSTEM METHODS
		void Awake ()
		{
			for (int i = 0; i < transform.childCount; i++) {
				placeHolderCells.Add (transform.GetChild (i).GetComponent<Cell> ());
			}
		}

		void Update(){
			//Debug.Log ("UPDATE:CELL:STATUS " + GetCellStatus());
		//	Debug.Log ("UPDATE:CELL:FILLED_COUNTER " + FilledCellCounter);

		}
	#endregion
	#region PUBLIC METHODS

		public void LookUpCurrentActiveCells (int levelComplexity)
		{
			for (int i = 0; i < levelComplexity; i++) {
				if (!activeCells.Contains (placeHolderCells [i]))
					activeCells.Add (placeHolderCells [i]);
			}
		}

		public void ClearActiveCellList ()
		{
			activeCells.Clear ();
		}

		void OnEnable(){
			Tile.cellFilledDelegate += CellFilledHandler;
			Tile.cellEmptiedDelegate += CellEmptiedHandler;

		}
		void OnDisable(){
			Tile.cellFilledDelegate -= CellFilledHandler;
			Tile.cellEmptiedDelegate -= CellEmptiedHandler;

		}
	
		private void CellFilledHandler(Cell cell,Tile tile){
			if (!ActiveTiles.Contains (tile)) {
				ActiveTiles.Add (tile);
				GetCellStatus();
				Debug.Log (" TILE  " + tile.name + " ADDED TO CELL " + (cell.CellIndex) + " STATUS IS " + CellStatus);
			}
		}
		private void CellEmptiedHandler(Cell cell,Tile tile){
			if (ActiveTiles.Contains (tile)){
				ActiveTiles.Remove(tile);
				GetCellStatus();
				Debug.Log (" TILE  " + tile.name + " REMOVED FROM CELL " +(cell!= null?cell.CellIndex:-1) + " STATUS IS " + CellStatus);
			}
		}
		public CellStatus GetCellStatus ()
		{
			if ( FilledCellCounter != null && (FilledCellCounter == ActiveCells.Count)) {
				cellStatus = CellStatus.FULLY_FILLED;
			} else if (FilledCellCounter > 0 && FilledCellCounter != activeCells.Count) {
				cellStatus = CellStatus.PARTIALY_FILLED;
			} else if (FilledCellCounter == 0) {
				cellStatus = CellStatus.EMPTY;
			}
			if (onCellStatusChangeDelegate != null)
				onCellStatusChangeDelegate (cellStatus);
			return cellStatus;
		}
	#endregion
	}
}