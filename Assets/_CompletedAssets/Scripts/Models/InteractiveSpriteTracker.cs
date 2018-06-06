﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractiveSpriteTracker : MonoBehaviour {
	[SerializeField]
	private Collider2D [] colliders;
	void Start(){
		colliders = gameObject.GetComponentsInChildren<Collider2D> ();
	}
	public void  DeactivateColliders() {
		foreach (var item in colliders) {
			item.enabled = false;
		}
	}

	public void ActivateColliders() {
		foreach (var item in colliders) {
			item.enabled = true;
		}
	}
}