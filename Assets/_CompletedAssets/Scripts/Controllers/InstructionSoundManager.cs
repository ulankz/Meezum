using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuizGame;
namespace MeezumGame
{
	public class InstructionSoundManager : MonoBehaviour
	{
		#region PRIVATE MEMBERS
		[SerializeField]
		private Dictionary<string,InstructionSounds> instructionSounds = new Dictionary<string, InstructionSounds>();
		[SerializeField]
		private AudioSource audioSource;
		[SerializeField]
		private InstructionSounds currentInstructionSoundInstance;
		#endregion
		#region SYSTEM METHODS
		private void Awake(){
			audioSource = gameObject.AddComponent<AudioSource> ();
			PopulateWholeInstructionSounds ();
		}

		#endregion
		#region PUBLIC METHODS

		public void PlayGameRule(string miniGame){
			Debug.Log("CHECK AM I HERE");
			if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
				audioSource.clip = currentInstructionSoundInstance.GameRule;
				if(!audioSource.isPlaying)
						audioSource.Play ();		
			}
		}
		public void PlayCallToAction(string miniGame){
			if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
				audioSource.clip = currentInstructionSoundInstance.CallToAction;
				if(!audioSource.isPlaying)
					audioSource.Play();
			}
		}
		public void PlayCallFirstClickToAction(string miniGame){
			switch(miniGame){
			case "QuizGame":
				if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
					audioSource.clip = (currentInstructionSoundInstance as InstructionSoundVictorina).FirstClickCallToAction;
					if(!audioSource.isPlaying)
						audioSource.Play();
				}
				break;
			default:
				break;
			}
		}
		public void PlayEnd(string miniGame){
			if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
				audioSource.clip = (currentInstructionSoundInstance as InstructionSoundVictorina).End;
				if(!audioSource.isPlaying)
					audioSource.Play();
			}
		}

		#endregion
		#region PRIVATE METHODS
		private void PopulateWholeInstructionSounds(){
			InstructionSounds quizGameSounds = new InstructionSoundVictorina ();
			instructionSounds.Add ("QuizGame", quizGameSounds);
		}
		#endregion
	}
}