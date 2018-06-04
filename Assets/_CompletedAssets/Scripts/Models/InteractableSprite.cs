using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems; 
public class InteractableSprite : MonoBehaviour {
	[SerializeField]
	private Sprite onHighlighted;
	[SerializeField]
	private Sprite onPressed;

	public Sprite onDisabled;

	[SerializeField]
	private SpriteRenderer sRenderer;
	[SerializeField]
	private UnityEvent onMouseDown; 
	[SerializeField]
	private UnityEvent onMouseEnter;
	[SerializeField]
	private UnityEvent onMouseExit; 
	// Use this for initialization
	void Start () {
		sRenderer = GetComponent<SpriteRenderer> ();
	}
	void OnMouseEnter(){
		if (!EventSystem.current.currentSelectedGameObject) {
			sRenderer.sprite = onHighlighted;
			onMouseEnter.Invoke ();
		}
	}
	void OnMouseExit(){
		if (!EventSystem.current.currentSelectedGameObject) {
			sRenderer.sprite = onDisabled;
			onMouseExit.Invoke ();
		}
	}
	void OnMouseDown(){
		if (!EventSystem.current.currentSelectedGameObject) {
			sRenderer.sprite = onPressed;
			onMouseDown.Invoke ();
		}
	}
}
