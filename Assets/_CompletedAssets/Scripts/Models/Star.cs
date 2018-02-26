using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
namespace QuizGame
{
	public class Star : MonoBehaviour
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private Image
			activeImg;
		#endregion

		#region PUBLIC MEMBERS
		public void ActivateStar ()
		{	
			activeImg.enabled = true;
		}
		public void DeactivateStar ()
		{
			activeImg.enabled = false;
		}	
		#endregion

	}
}