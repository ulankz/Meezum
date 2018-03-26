using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace MeezumGame
{
	public class SoundManager : MonoBehaviour
	{
		#region PRIVATE FIELDS
		private AudioSource audioSource;
		#endregion
		#region SYSTEM FUNCTIONS
		void Awake ()
		{
			gameObject.tag = Tags.SOUND_MANAGER;
		}
		void Start(){
			audioSource = gameObject.AddComponent<AudioSource> ();
		}
		#endregion
		#region PUBLIC PROPERTIES
		public AudioSource AudioSource {
			get {
				return this.audioSource;
			}
			set {
				audioSource = value;
			}
		}
		#endregion
		#region PUBLIC METHODS
		public void PlaySound(AudioClip audioClip,float delay){
			if (AudioSource != null && !AudioSource.isPlaying) {
				AudioSource.clip = audioClip;
				AudioSource.PlayDelayed(delay);
			}
		}
		public void PlaySound(AudioClip audioClip){
			if (AudioSource != null && !AudioSource.isPlaying) {
				AudioSource.clip = audioClip;
				AudioSource.Play();
			}
		}
		#endregion
	}
}
