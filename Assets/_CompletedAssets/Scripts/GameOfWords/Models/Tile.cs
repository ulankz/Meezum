using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeezumGame;
namespace GameOfWords
{
	public class Tile : MonoBehaviour
	{
	#region DELEGATES AND EVENTS
		public delegate void OnCellFilledDelegate(Cell cell,Tile tile);
		public static event OnCellFilledDelegate cellFilledDelegate;
		public delegate void OnCellEmptyDelegate(Cell cell,Tile tile);
		public static event OnCellEmptyDelegate cellEmptiedDelegate;

	#endregion
	#region PRIVATE MEMBERS
		[SerializeField]
		private Vector2 startingPosition;
		[SerializeField]
		private List<Transform> touchingCells;
		[SerializeField]
		private Transform myParent;		//Caching for optimisation
		private AudioSource audSource;
		[SerializeField]
		private Vector3 pickUpScale = new Vector3(1.1f,1.1f,1.1f);
		[SerializeField]
		private Vector3 dropScale = Vector3.one;
		private bool used = false;
		private Cell filledCell;
	#endregion
	#region SYSTEM METHODS
		void Start ()
		{
			startingPosition = transform.position;
			touchingCells = new List<Transform> ();
			myParent = transform.parent;
			audSource = gameObject.GetComponent<AudioSource> ();
		}
		void OnTriggerEnter2D (Collider2D other)
		{
			if (other.tag != Tags.CELL)
				return;
			if (!touchingCells.Contains (other.transform)) {
				if(other.transform.childCount == 0){
					touchingCells.Add (other.transform);
				}
//				if(cellFilledDelegate!= null)
//					cellFilledDelegate(other.GetComponent<Cell>(),transform.GetComponent<Tile>());
				Debug.Log(" EXECUTES LINE touchingCells.Add (other.transform)");		
			}
		}

		void OnTriggerExit2D (Collider2D other)
		{
			if (other.tag != Tags.CELL)
				return;
			if (touchingCells.Contains (other.transform)) {
				touchingCells.Remove (other.transform);
								//if(cellEmptiedDelegate!= null)
									//cellEmptiedDelegate(other.GetComponent<Cell>(),transform.GetComponent<Tile>());
				Debug.Log(" EXECUTES LINE touchingCells.Remove (other.transform)");
			}
		}
	#endregion
	#region PUBLIC METHODS
		public void PutToInitialPlace(){

			transform.position = startingPosition;
			transform.SetParent (myParent);
		}
		public void PickUp ()
		{
			Debug.Log ("PICKUP IS CALLED");
			transform.localScale = pickUpScale;
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		}
		public void Drop ()
		{
			transform.localScale = dropScale;
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 3;
			Vector2 newPosition;
			if (touchingCells.Count == 0) { // If the tile is not placed in any cell then move the tile to original place
				transform.position = startingPosition;
				transform.SetParent (myParent);
				if(cellEmptiedDelegate!= null)
					cellEmptiedDelegate(null,transform.GetComponent<Tile>());
				Debug.Log(" EXECUTES LINE touchingCells.Count == 0 return");
				return;	
			} else {
				var currentCell = touchingCells [0];
				if (touchingCells.Count == 1) {
					newPosition = currentCell.position;
				} else {
					float distance = Vector2.Distance (transform.position, touchingCells [0].position);
					foreach (Transform cell in touchingCells) {
						if (Vector2.Distance (transform.position, cell.position) < distance) {
							currentCell = cell;
							distance = Vector2.Distance (transform.position, cell.position);
						}	
					}
					newPosition = currentCell.position;
				}
				if (currentCell.childCount != 0) {
					transform.position = startingPosition;
					transform.SetParent (myParent);
					Debug.Log(" EXECUTES LINE currentCell.childCount != 0 ");
					if(cellEmptiedDelegate!= null)
						cellEmptiedDelegate(currentCell.GetComponent<Cell>(),transform.GetComponent<Tile>());
					return;
				} else{
					Debug.Log(" EXECUTES LINE currentCell.childCount == 0 ");
					transform.SetParent (currentCell);
					if(cellFilledDelegate!= null)
						cellFilledDelegate(currentCell.GetComponent<Cell>(),transform.GetComponent<Tile>());
					StartCoroutine (SlotIntoPlace (transform.position, newPosition));
				}
			}
		}
	#endregion
	#region PRIVATE METHODS
		private IEnumerator SlotIntoPlace (Vector2 startingPos, Vector2 endingPos)
		{
			float duration = 0.1f;
			float elapsedTime = 0;
			audSource.Play ();
			while (elapsedTime < duration) {
				transform.position = Vector2.Lerp (startingPos, endingPos, elapsedTime / duration);
				elapsedTime += Time.deltaTime;
				yield return new WaitForEndOfFrame ();
			}
			transform.position = endingPos;
		}
	#endregion
	}
}
