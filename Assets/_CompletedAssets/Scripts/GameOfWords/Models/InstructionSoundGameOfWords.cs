using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeezumGame;
namespace GameOfWords
{	[System.Serializable]
	public class InstructionSoundGameOfWords : InstructionSounds
	{
		#region PRIVATE MEMBERS
		private static int correctSoundsSize = 4;
		private static int wrongSoundSize = 2;
		private AudioClip[] corrects = new AudioClip[correctSoundsSize];
		private AudioClip[] wrongs = new AudioClip[wrongSoundSize];
		private AudioClip end;
		private AudioClip fullFilledReactionSound;
		private AudioClip partiallyFilledReactionSound;

		#endregion
		#region CONSTRUCTORS
		public InstructionSoundGameOfWords():base(){
			//Debug.Log ("INSTRUCTION_SOUNDS_VICTORINA_DEFAULT CONSTRUCTOR IS CALLED");
		}
		#endregion
		#region PROPERTY MEMBERS
		public AudioClip[] Corrects {
			get {
				return this.corrects;
			}
			set {
				corrects = value;
			}
		}

		public AudioClip[] Wrongs {
			get {
				return this.wrongs;
			}
			set {
				wrongs = value;
			}
		}

		public AudioClip End {
			get {
				return this.end;
			}
			set {
				end = value;
			}
		}
		public AudioClip FullFilledReactionSound {
			get {
				return this.fullFilledReactionSound;
			}
			set {
				fullFilledReactionSound = value;
			}
		}

		public AudioClip PartiallyFilledReactionSound {
			get {
				return this.partiallyFilledReactionSound;
			}
			set {
				partiallyFilledReactionSound = value;
			}
		}
		#endregion

		#region PROTECTED METHODS
		protected override void LoadAudioClips ()
		{	
			base.LoadAudioClips ();

			GameRule = Resources.Load ("Sounds/QuizGame/gameRule", typeof(AudioClip)) as AudioClip;
			CallToAction = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			FullFilledReactionSound = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			PartiallyFilledReactionSound  = Resources.Load ("Sounds/QuizGame/callToAction", typeof(AudioClip)) as AudioClip;
			End = Resources.Load ("Sounds/QuizGame/correct_0", typeof(AudioClip)) as AudioClip;
			Corrects[0] = Resources.Load ("Sounds/QuizGame/correct_0", typeof(AudioClip)) as AudioClip;
			Corrects[1] = Resources.Load ("Sounds/QuizGame/correct_1", typeof(AudioClip)) as AudioClip;
			corrects[2] = Resources.Load ("Sounds/QuizGame/correct_1", typeof(AudioClip)) as AudioClip;
			corrects[3] = Resources.Load ("Sounds/QuizGame/correct_0", typeof(AudioClip)) as AudioClip;
			Wrongs[0] = Resources.Load ("Sounds/QuizGame/wrong_0", typeof(AudioClip)) as AudioClip;
			Wrongs[1] = Resources.Load ("Sounds/QuizGame/wrong_1", typeof(AudioClip)) as AudioClip;
//			wrongs[2] = Resources.Load ("Sounds/QuizGame/wrong_2", typeof(AudioClip)) as AudioClip;
//			wrongs[3] = Resources.Load ("Sounds/QuizGame/wrong_3", typeof(AudioClip)) as AudioClip;
			Debug.Log ("LOAD_AUDIO_CLIPS : AudioClips loaded successfully");
		}	
		#endregion
	}
}