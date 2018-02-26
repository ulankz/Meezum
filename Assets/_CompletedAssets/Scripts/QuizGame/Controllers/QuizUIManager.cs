using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using MeezumGame;
namespace QuizGame
{
	public class QuizUIManager : MonoBehaviour, UIManagable
	{

		#region PRIVATE MEMBERS
		[SerializeField]
		private GameObject quizPanel;
		[SerializeField]
		private Image character;
		[SerializeField]
		private GameObject gamePanel;
		[SerializeField]
		private GameObject buttonContainer;
		[SerializeField] 
		private GameObject questionPanel;
		[SerializeField]
		private Text question;
		[SerializeField]
		private GameObject starManager;	
		#endregion
		void Awake(){
			starManager = GameObject.FindGameObjectWithTag(Tags.STAR_MANAGER);
		}
	}
}