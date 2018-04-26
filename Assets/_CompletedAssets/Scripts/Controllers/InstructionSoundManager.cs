using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using QuizGame;
using GameOfWords;
using Classification;
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
			gameObject.tag = Tags.INSTRUCTIONS_SOUND_MANAGER;
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
				if(miniGame == "QuizGame")
					audioSource.clip = (currentInstructionSoundInstance as InstructionSoundVictorina).End;
				else if(miniGame == "GameWords"){
					audioSource.clip = (currentInstructionSoundInstance as InstructionSoundGameOfWords).End;
				}
				
				if(!audioSource.isPlaying)
					audioSource.Play();
			}
		}
		public void PlayFullReactionSound(string miniGame){
				if (instructionSounds.TryGetValue (miniGame, out currentInstructionSoundInstance)) {
					if (miniGame == "Classification")
						audioSource.clip = (currentInstructionSoundInstance as InstructionSoundClassification).FullSelectedReactionSound;
					else if (miniGame == "GameWords") {
						audioSource.clip = (currentInstructionSoundInstance as InstructionSoundGameOfWords).FullFilledReactionSound;
					}
					if (!audioSource.isPlaying)
						audioSource.Play ();
				}
			}
		
		public void PlayPartiallyReactionSound(string miniGame){
			if (instructionSounds.TryGetValue (miniGame, out currentInstructionSoundInstance)) {
				if (miniGame == "Classification")
					audioSource.clip = (currentInstructionSoundInstance as InstructionSoundClassification).PartiallySelectedReactionSound;
				else if (miniGame == "GameWords") {
					audioSource.clip = (currentInstructionSoundInstance as InstructionSoundGameOfWords).PartiallyFilledReactionSound;
				}
				if (!audioSource.isPlaying)
					audioSource.Play ();
			}
		}

		public void PlayRightCombinationSound (string miniGame){
			int correctSoundsSize;
			if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
				correctSoundsSize = (currentInstructionSoundInstance as InstructionSoundGameOfWords).Corrects.Length;
				audioSource.clip = (currentInstructionSoundInstance as InstructionSoundGameOfWords).Corrects[Random.Range(0, correctSoundsSize)];
			}
			if(!audioSource.isPlaying)
				audioSource.Play();
		}
		public void PlayWrongCombinationSound (string miniGame){
			int wrongSoundsSize;
			
			if (instructionSounds.TryGetValue (miniGame,out currentInstructionSoundInstance)){
				wrongSoundsSize = (currentInstructionSoundInstance as InstructionSoundGameOfWords).Wrongs.Length;
				audioSource.clip = (currentInstructionSoundInstance as InstructionSoundGameOfWords).Wrongs[Random.Range(0, wrongSoundsSize)];
			}
			
			
			if(!audioSource.isPlaying)
				audioSource.Play();
		}
		#endregion
		#region PRIVATE METHODS
		private void PopulateWholeInstructionSounds(){
			InstructionSounds quizGameSounds = new InstructionSoundVictorina ();
			instructionSounds.Add ("QuizGame", quizGameSounds);
			InstructionSounds gameWordsSounds = new InstructionSoundGameOfWords ();
			instructionSounds.Add ("GameWords",gameWordsSounds);
		}
		#endregion
	}
}