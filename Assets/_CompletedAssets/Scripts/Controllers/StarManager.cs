using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuizGame
{
	public class StarManager : MonoBehaviour
	{
		#region PRIVATE FIELDS
		[SerializeField]
		private GameObject
			starPanel;
		[SerializeField]
		private Star[]
			starContainer;
		#endregion  
		void Awake ()
		{
			if (starPanel != null && isActiveAndEnabled) {
				starContainer = starPanel.GetComponentsInChildren<Star> ();
				foreach(Star s in starContainer){
					s.DeactivateStar();
				}
			}
		}
		#region PUBLIC METHODS
		public void SetStar(int i){
			if (starContainer.Length > 0 && (i >= 0 || i < starContainer.Length))
				starContainer [i].ActivateStar ();
		}
		public void UnsetStar(int i){
			if (starContainer.Length > 0 && (i >= 0 || i < starContainer.Length))
				starContainer [i].DeactivateStar ();
		}
		#endregion

	}
}