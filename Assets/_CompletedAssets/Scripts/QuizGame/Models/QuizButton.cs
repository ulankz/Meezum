
using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.Events;


namespace QuizGame
{
	[System.Serializable]
	public class QuizButton : Button
	{

		#region PUBLIC MEMBERS
		[System.Serializable]
		public class OnSingleClick : UnityEvent {};
		public OnSingleClick onSingleClickAction;
		
		[System.Serializable]
		public class OnDoubleClick : UnityEvent {};
		public OnDoubleClick onDoubleClickAction;

		public Text
			buttonLabel;

		public Image
			buttonImage;

		public Sprite[] stateImages;// 3 sprites in the array || 0-index: default sprite || 1-index: correct sprite || 2- index: wrong sprite

		public Sprite offSprite;
		public Sprite onSprite;
		public Color offTextColor = Color.white;
		public Color onTextColor = Color.white;
		
		private bool isSelected;
		public bool IsSelected {
			get {
				return isSelected;
			}
			set {
				isSelected = value;
				
				Text text = this.transform.GetComponentInChildren<Text> ();
				
				if (value) {
					buttonImage.sprite = onSprite;
					buttonLabel.color = onTextColor;
				} else {
					this.GetComponent<Image> ().sprite = offSprite;
					text.color = offTextColor;
				}
			}
		}
		private bool isSingleClicked;

		public bool IsSingleClicked
		{
			get {
				return isSingleClicked;
			}
			set {
				isSingleClicked = value;
			}
		}

		private bool isDoubleClicked;
		
		public bool IsDoubleClicked
		{
			get {
				return isDoubleClicked;
			}
			set {
				isDoubleClicked = value;
			}
		}
		
		#endregion

		protected override void Awake ()
		{
			buttonLabel = gameObject.transform.GetComponentInChildren<Text> ();
			buttonImage = gameObject.GetComponent<Image> ();
		}

		#region PUBLIC MEMBERS
		public void UpdateButton (string description)
		{
			if (buttonLabel != null)
				buttonLabel.text = description;
		}
		public void SetDefaultState ()
		{
			buttonImage.sprite = stateImages [0];// Sets  sprite for default state
		}
		public void SetCorrectChoiceState ()
		{
			buttonImage.sprite = stateImages [1];// Sets  sprite for correct state
		}
		public void SetWrongChoiceState ()
		{
			buttonImage.sprite = stateImages [2];// Sets  sprite for wrong state
		}
		public void SetInProcessState ()
		{
			buttonImage.sprite = stateImages [0];// Sets  sprite for correct state
		}
		#endregion
		#region CHECK FOR DOUBLE CLICK
		private float clickTime;            // time of click
//		private bool onSingleClick = true;            // is click allowed on button?
//		private bool onDoubleClick = true;    // is double-click allowed on button?
		#endregion
		#region PRIVATE MEMBERS
		private string singleClickButtonID;	
		private string doubleClickButtonID;
		#endregion

		int tap;
		float interval = 0.1f;
		bool readyForDoubleTap;
		public override void OnPointerClick(PointerEventData eventData)
		{
			tap ++;


			if (tap == 1)
			{
				//do stuff
				Debug.Log("BUTTON IS SINGLE TAPPED");
				this.onSingleClickAction.Invoke();
				StartCoroutine("Delay");
				StartCoroutine(DoubleTapInterval() );

			}
			
			else if (tap > 1 && readyForDoubleTap)
			{
				//do stuff
				this.onDoubleClickAction.Invoke();
				Debug.Log("BUTTON IS DOUBLE TAPPED");
				tap = 0;
				StopCoroutine("Delay");
				readyForDoubleTap = false;
			}
		}
		
		IEnumerator DoubleTapInterval()
		{  
			yield return new WaitForSeconds(interval);
			readyForDoubleTap = true;

		}
		IEnumerator Delay(){
			yield return new WaitForSeconds (5f);
			Debug.Log ("TO CHECK AN ANSWER CLICK ONE MORE TIME");
		}


	}
		
}
