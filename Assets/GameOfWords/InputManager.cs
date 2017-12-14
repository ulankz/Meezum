using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {

	private bool draggingItem = false;
	private GameObject draggedObject;
	private Vector2 touchOffset;

	void Update ()
	{
		if (HasInput)
		{
			DragOrPickUp();
		}
		else
		{
			if (draggingItem)
				DropItem();
		}
	}

	Vector2 CurrentTouchPosition
	{
		get
		{
			Vector2 inputPos;
			inputPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			return inputPos;
		}
	}

	private void DragOrPickUp()
	{
		var inputPosition = CurrentTouchPosition;

		if (draggingItem)
		{
			draggedObject.transform.position = inputPosition + touchOffset;
		}
		else
		{
			RaycastHit2D[] touches = Physics2D.RaycastAll(inputPosition, inputPosition, 0.5f);
			if (touches.Length > 0)
			{
				var hit = touches[0];
				if (hit.transform != null && hit.transform.tag == "Tile")
				{
					draggingItem = true;
					draggedObject = hit.transform.gameObject;
					touchOffset = (Vector2)hit.transform.position - inputPosition;
					draggedObject.transform.localScale = new Vector3(100.2f,100.2f,100.2f);
					hit.transform.GetComponent<Tile>().PickUp();
				}
			}
		}
	}

	private bool HasInput
	{
		get
		{
			// returns true if either the mouse button is down or at least one touch is felt on the screen
			return Input.GetMouseButton(0);
		}
	}

	void DropItem()
	{
		draggingItem = false;
		draggedObject.transform.localScale = new Vector3(100f,100f,100f);
		draggedObject.GetComponent<Tile> ().Drop ();
	}
}
