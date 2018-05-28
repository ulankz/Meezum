using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using MeezumGame;
namespace Localization{
public class StartupManager : MonoBehaviour {
	
	// Use this for initialization
	private IEnumerator Start () 
	{
		while (!LocalizationManager.instance.GetIsReady ()) 
		{
			yield return null;
		}
		
		SceneManager.LoadScene (Scenes.COMICS_SCENE);
	}
	
}
}