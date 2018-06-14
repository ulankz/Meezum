using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Joystick : MonoBehaviour {

	private Vector2 inputVector;

	public Vector2 InputVector {
		get {
			return this.inputVector;
		}
		set {
			inputVector = value;
		}
	}

	public void move(string direction) {
		switch (direction) {
			case "right":
				inputVector.x = 1;
				inputVector.y = 0;
				break;
			case "left":
				inputVector.x = -1;
				inputVector.y = 0;
				break;
			case "up":
				inputVector.x = 0;
				inputVector.y = 1;
				break;
			case "down":
				inputVector.x = 0;
				inputVector.y = -1;
				break;
		}
	}

	public void stop() {
		inputVector = new Vector2(0, 0);
	}
}
