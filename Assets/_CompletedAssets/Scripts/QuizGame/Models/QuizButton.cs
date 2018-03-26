
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

		public delegate void OnSingleClickCallDelegate();
		
		public static event OnSingleClickCallDelegate singleClickCallDelegate;

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
			LoadAudios ();
			aSource = gameObject.GetComponent<AudioSource> ();
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
		public AudioClip AnswerDescriptionAudio {
			get {
				return this.answerDescriptionAudio;
			}
			set {
				answerDescriptionAudio = value;
			}
		}
		public AudioClip ButtonClickCorrectSound {
			get {
				return this.buttonClickCorrectSound;
			}
			set {
				buttonClickCorrectSound = value;
			}
		}
		public AudioClip ButtonClickWrongSound {
			get {
				return this.buttonClickWrongSound;
			}
			set {
				buttonClickWrongSound = value;
			}
		}
		public AudioClip ButtonClickDefaultSound {
			get {
				return this.buttonClickDefaultSound;
			}
			set {
				buttonClickDefaultSound = value;
			}
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
		private AudioClip answerDescriptionAudio;
		private AudioClip buttonClickCorrectSound;
		private AudioClip buttonClickWrongSound;
		private AudioClip buttonClickDefaultSound;
		[SerializeField]
		private AudioSource aSource;
		#endregion

		int tap;
		float interval = 0.1f;
		bool readyForDoubleTap;
		public override void OnPointerClick(PointerEventData eventData)
		{
			base.OnPointerClick (eventData);
			tap ++;


			if (tap == 1)
			{
				//do stuff
				PlayAnswerDescriptionSound();
				Debug.Log("BUTTON IS SINGLE TAPPED");
				this.onSingleClickAction.Invoke();
				StartCoroutine("Delay");
				StartCoroutine(DoubleTapInterval() );

			}
			
			else if (tap > 1 && readyForDoubleTap)
			{
				//do stuff
				PlayButtonSound();
				this.onDoubleClickAction.Invoke();
				Debug.Log("BUTTON IS DOUBLE TAPPED");
				tap = 0;
				readyForDoubleTap = false;
				StopCoroutine("Delay");

			}
		}

//		void PlayButtonSound (string state)
//		{
//			switch(state){
//			case "correct":
//				aSource.clip = ButtonClickCorrectSound;
//				break;
//			case "wrong":
//				aSource.clip = ButtonClickWrongSound;
//				break;
//			}
//			if (!aSource.isPlaying)
//				aSource.Play ();
//		}
		void PlayButtonSound (){
			aSource.clip = ButtonClickDefaultSound;
			if (!aSource.isPlaying)
				aSource.Play ();
		}
		void PlayAnswerDescriptionSound ()
		{
			aSource.clip = AnswerDescriptionAudio;
			if (!aSource.isPlaying)
				aSource.Play ();
		}
		
		IEnumerator DoubleTapInterval()
		{  
			yield return new WaitForSeconds(interval);
			readyForDoubleTap = true;

		}
		IEnumerator Delay(){
			yield return new WaitForSeconds (5f);
			if (singleClickCallDelegate != null)
				singleClickCallDelegate ();
			Debug.Log ("TO CHECK AN ANSWER CLICK ONE MORE TIME");

		}

		private void LoadAudios(){
			AnswerDescriptionAudio = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			ButtonClickCorrectSound = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			ButtonClickWrongSound = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			ButtonClickDefaultSound = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
		}
	}
		
}
