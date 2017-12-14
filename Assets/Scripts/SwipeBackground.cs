using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SwipeBackground : MonoBehaviour {

	public Swipe swipeControls;

	private int swipeIndex;
	public Sprite sprite;
	public GameObject other;
	private Camera camera;
	private Vector3 camBound;

	// Use this for initialization
	void Start () {
		camera = other.GetComponent<Camera>();
		swipeIndex = 0;
		camBound = camera.ScreenToWorldPoint (new Vector3 (0, 0, camera.nearClipPlane));
	}
	
	// Update is called once per frame
	void Update () {
		float x = 0.0f;
		if (swipeControls.SwipeLeft && swipeIndex > -1) {
			x = gameObject.transform.position.x - (sprite.bounds.max.x*0.65f - Mathf.Abs(camBound.x));
			swipeIndex -= 1;
			//print ("Moving left");
			gameObject.transform.position = new Vector3(x, gameObject.transform.position.y, gameObject.transform.position.z) ;
		}
		if (swipeControls.SwipeRight && swipeIndex < 1) {
			x = gameObject.transform.position.x + sprite.bounds.max.x * 0.65f - Mathf.Abs (camBound.x);
			swipeIndex += 1;
			//print ("Moving right");
			gameObject.transform.position = new Vector3(x, gameObject.transform.position.y, gameObject.transform.position.z) ;
		}
	}
}
