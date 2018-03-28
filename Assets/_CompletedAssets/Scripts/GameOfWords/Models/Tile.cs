using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeezumGame;
namespace GameOfWords
{
	public class Tile : MonoBehaviour
	{
	#region PRIVATE MEMBERS
		[SerializeField]
		private Vector2 startingPosition;
		[SerializeField]
		private List<Transform> touchingTiles;
		[SerializeField]
		private Transform myParent;		//Caching for optimisation
		private AudioSource audSource;
		[SerializeField]
		private Vector3 pickUpScale = new Vector3(1.1f,1.1f,1.1f);
		[SerializeField]
		private Vector3 dropScale = Vector3.one;
	#endregion
	#region SYSTEM METHODS
		void Start ()
		{
			startingPosition = transform.position;
			touchingTiles = new List<Transform> ();
			myParent = transform.parent;
			audSource = gameObject.GetComponent<AudioSource> ();
		}

		void OnTriggerEnter2D (Collider2D other)
		{
			if (other.tag != Tags.CELL)
				return;
			if (!touchingTiles.Contains (other.transform)) {
				touchingTiles.Add (other.transform);
			}
		}
		
		void OnTriggerExit2D (Collider2D other)
		{
			if (other.tag != Tags.CELL)
				return;
			if (touchingTiles.Contains (other.transform)) {
				touchingTiles.Remove (other.transform);
			}
		}
	#endregion
	#region PUBLIC METHODS
		public void PickUp ()
		{
			transform.localScale = pickUpScale;
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 4;
		}

		public void Drop ()
		{
			transform.localScale = dropScale;
			gameObject.GetComponent<SpriteRenderer> ().sortingOrder = 3;

			Vector2 newPosition;
			if (touchingTiles.Count == 0) {
				transform.position = startingPosition;
				transform.SetParent(myParent);
				return;
			}
			var currentCell = touchingTiles [0];
			if (touchingTiles.Count == 1) {
				newPosition = currentCell.position;
			} else {
				float distance = Vector2.Distance (transform.position, touchingTiles [0].position);

				foreach (Transform cell in touchingTiles) {
					if (Vector2.Distance (transform.position, cell.position) < distance) {
						currentCell = cell;
						distance = Vector2.Distance (transform.position, cell.position);
					}	
				}
				newPosition = currentCell.position;
			}
			if (currentCell.childCount != 0) {
				transform.position = startingPosition;
				transform.SetParent(myParent);
				return;
			} else {
				transform.SetParent(currentCell);
				StartCoroutine (SlotIntoPlace (transform.position, newPosition));
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
