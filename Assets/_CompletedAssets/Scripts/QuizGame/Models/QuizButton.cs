using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace QuizGame
{
	public class QuizButton : Button
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private Text
			buttonLablel;
		#endregion
		void Awake ()
		{
			buttonLablel = gameObject.transform.GetComponentInChildren<Text> ();
		}
		#region PUBLIC MEMBERS
		public void UpdateButton(string description){
			if (buttonLablel != null)
				buttonLablel.text = description;
		}
		#endregion
	}
}
