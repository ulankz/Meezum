using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MeezumGame{
	public abstract class UITrackable : MonoBehaviour{
		public bool isHidden = false;
		void OnEnable(){
			SceneManager.sceneLoaded += OnLevelLoadFinished;
		}
		void OnDisable(){
			SceneManager.sceneLoaded -= OnLevelLoadFinished;
		}
		public abstract void OnLevelLoadFinished (Scene scene,LoadSceneMode mode);
}
}