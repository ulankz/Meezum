using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuizGame;
namespace MeezumGame
{
	public class SoundManager : MonoBehaviour
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
		private void Start(){
			audioSource = gameObject.AddComponent<AudioSource> ();
			PopulateWholeInstructionSounds ();
		}

		#endregion
		#region PUBLIC METHODS

		public void PlayGameRule(string miniGame){
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
					audioSource.Play ();		
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