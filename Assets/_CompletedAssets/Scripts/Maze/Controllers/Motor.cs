using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace Maze{
public class Motor : MonoBehaviour {

	public float moveSpeed = 5.0f;
	public float drag = 0.5f;
	public float terminalRotationSpeed = 25.0f;
	public VirtualJoystick moveJoystick;
	// Use this for initialization
	private Rigidbody controller;
	private Transform camTransform;
		Vector3 dir;
	void Start () {
		controller = GetComponent<Rigidbody> ();
		controller.maxAngularVelocity = terminalRotationSpeed;
		controller.drag = drag;
		
		camTransform = Camera.main.transform;
		
	}
	
	// Update is called once per frame
	void Update () {
		 dir = Vector3.zero;
			dir.x = Input.GetAxis ("Horizontal");
			dir.z = Input.GetAxis ("Vertical");
			if (dir.magnitude > 1)
				dir.Normalize ();
			if (moveJoystick.InputDirection != Vector3.zero) {
				dir = moveJoystick.InputDirection;
			}

			//Rotate our direction vector with camera
			Vector3 rotatedDir = camTransform.TransformDirection (dir);
			rotatedDir.Set(rotatedDir.x, 0.0f, rotatedDir.z);
			rotatedDir = rotatedDir.normalized * dir.magnitude;

			controller.AddForce (rotatedDir * moveSpeed);
	}
}
}
