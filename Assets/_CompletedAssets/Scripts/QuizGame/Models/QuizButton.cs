using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QuizGame
{
	[System.Serializable]
	public class QuizButton : Button
	{

		#region PRIVATE MEMBERS
		protected QuizButton() : base(){
		
		}
		[SerializeField]
		private Text
			buttonLablel;
		[SerializeField]
		private Image
			buttonImage;
		[SerializeField]
		private Sprite[] stateImages;// 3 sprites in the array || 0-index: default sprite || 1-index: correct sprite || 2- index: wrong sprite


		#endregion
		void Awake ()
		{
			buttonLablel = gameObject.transform.GetComponentInChildren<Text> ();
			buttonImage = gameObject.GetComponent<Image>();
		}

		#region PUBLIC MEMBERS
		public void UpdateButton(string description){
			if (buttonLablel != null)
				buttonLablel.text = description;
		}
		public void SetDefaultState(){
			buttonImage.sprite = stateImages [0];// Sets  sprite for correct state
		}
		public void SetCorrectChoiceState(){
			buttonImage.sprite = stateImages [1];// Sets  sprite for correct state
		}
		public void SetWrongChoiceState(){
			buttonImage.sprite = stateImages [2];// Sets  sprite for correct state
		}
		public void SetInProcessState(){
			buttonImage.sprite = stateImages [0];// Sets  sprite for correct state
		}

		#endregion
	}
		
}
