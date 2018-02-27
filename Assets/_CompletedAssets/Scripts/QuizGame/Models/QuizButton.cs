
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

		void Awake ()
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
		private bool onClick = true;            // is click allowed on button?
		private bool onDoubleClick = true;    // is double-click allowed on button?
		#endregion
		public override void OnPointerClick (PointerEventData eventData)
		{
			base.OnPointerClick (eventData);

			int clickCount = 0;
			Debug.Log ("Initial click count " + clickCount);
			IsSingleClicked = false;
			IsDoubleClicked = false;
			//this.transform.parent.GetComponent<UISegmentedControl>().SelectSegment(this);

			clickCount = 1; // single click


			
			// get interval between this click and the previous one (check for double click)
			float interval = eventData.clickTime - clickTime;
			
			// if this is double click, change click count
			if (interval < 5f && interval > 0)
				clickCount = 2;
			
			// reset click time
			clickTime = eventData.clickTime;
			
			// single click
			if (onClick && clickCount == 1)
			{
				IsSingleClicked = true;
				onSingleClickAction.Invoke();
				Debug.Log ("SingleClick " + clickCount);
				SetWrongChoiceState();

			}
			
			// double click
			if (onDoubleClick && clickCount == 2)
			{	
				IsDoubleClicked = true;
				onDoubleClickAction.Invoke();
				SetCorrectChoiceState();
				Debug.Log ("Double click " + clickCount);
			}		
		}


	}
		
}
