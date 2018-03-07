using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
namespace MeezumGame
{
	[Serializable]
	public abstract class InstructionSounds
	{
		#region PRIVATE MEMBERS
		protected	AudioClip gameRule;
		protected AudioClip callToAction;
		#endregion
		#region CONSTRUCTORS
		public InstructionSounds(){
			Debug.Log ("INSTRUCTION_SOUNDS_DEFAULT CONSTRUCTOR IS CALLED");
			LoadAudioClips ();
		}
		#endregion
		#region PROPERTY MEMBERS
		public AudioClip GameRule {
			get {
				return this.gameRule;
			}
			set {
				gameRule = value;
			}
		}

		public AudioClip CallToAction {
			get {
				return this.callToAction;
			}
			set {
				callToAction = value;
			}
		}
		#endregion
		#region PROTECTED MEMBERS
		protected virtual void LoadAudioClips(){

		}
		#endregion
	
	}
}