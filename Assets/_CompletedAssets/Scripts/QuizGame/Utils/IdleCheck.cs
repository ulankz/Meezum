using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

namespace MeezumGame
{
	public class IdleCheck : MonoBehaviour
	{
		// DELEGATES AND EVENTS
		public delegate void OnIdleChangeDelegate (bool flag);

		public static event OnIdleChangeDelegate idleChangeDelegate;

		float idle_lim = 15.0f;
		float last_ui = 0.0f;
		private bool idle = false;

		public bool Idle {
			get { 
				return idle;
			}
			set { 
				if (idle != value) {
					idle = value;
					if (idle && UIAlertView.instance.active_alert_views.Count < 1) {
						UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Title", "message", "Hello world", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
						if (idleChangeDelegate != null)
							idleChangeDelegate (idle);
					}
				}
			}
		}
		void Awake ()
		{
			gameObject.tag = Tags.NOTIFICATION_MANAGER;
		}

		void Start ()
		{
			//OnIdleChange += OnIdleChangeHandler;
		}

		void FixedUpdate ()
		{
			if ((Input.anyKeyDown)) {
				if (Idle) {
					Idle = false;
				}
				last_ui = Time.time;
			}
			if ((Time.time - last_ui) > idle_lim) {
				Idle = true;
				// initiate some action in case of idle state

			}
		}


		// EVENT HANDLERS
//		private void OnIdleChangeHandler ()
//		{
//			UIAlertView.instance.ShowSimpleAlertView (gameObject, UIAlertView.Hash ("title", "Title", "message", "Hello world", "button1title", "OK", "button1callback", "SimpleAlertCallback"));
//			//Debug.Log ("OnLevelComplexityChangeHandler IS CALLED " + (int)levelComplexity);
//		}

		void Destroy ()
		{
			//	OnIdleChange -= OnIdleChangeHandler;
		}
	}
}