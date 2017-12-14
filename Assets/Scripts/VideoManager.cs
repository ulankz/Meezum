using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VideoManager : MonoBehaviour {

	private string movPath = "main.mp4";

	// Use this for initialization
	void Start () {
		gameObject.GetComponent<Button> ().onClick.AddListener (TaskOnClick);
	}

	private IEnumerator PlayStreamingVideo(string url) {
		#if UNITY_IPHONE || UNITY_ANDROID
			Handheld.PlayFullScreenMovie (url, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
			yield return new WaitForEndOfFrame ();
		#endif
		yield return 0;
	}

	void TaskOnClick() {
		#if UNITY_IPHONE || UNITY_ANDROID
			Handheld.PlayFullScreenMovie (movPath, Color.black, FullScreenMovieControlMode.Full, FullScreenMovieScalingMode.AspectFill);
		#endif
	}


}
