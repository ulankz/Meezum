using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MeezumGame{
	public class ForestUITrack : UITrackable {

	[SerializeField]
	private GameObject missionsPanel;
	[SerializeField]
	private GameObject optionsPanel;
	// Use this for initialization
	[SerializeField]
	private CanvasGroup optionsPanelCanvas;
	[SerializeField]
	private CanvasGroup missionsPanelcanvas;
		void Start(){
			missionsPanel = GlobalGameManager.instance.Main_UI_Manager.missionsPanel;//GameObject.FindGameObjectWithTag (Tags.MISSION_PANEL);
			optionsPanel = GlobalGameManager.instance.Main_UI_Manager.optionsPanel;//GameObject.FindGameObjectWithTag (Tags.OPTIONS_PANEL);
			optionsPanelCanvas = optionsPanel.GetComponent<CanvasGroup> ();
			missionsPanelcanvas = missionsPanel.GetComponent<CanvasGroup> ();
		}
	// Update is called once per frame
	void Update () {
			isHidden = (missionsPanelcanvas.alpha!=1 && optionsPanelCanvas.alpha != 1);
	}
		public override void OnLevelLoadFinished(Scene scene,LoadSceneMode mode){
			
			switch(scene.name){
			case Scenes.MAIN_MENU_SCENE:
				
				break;
			default:
				break;
			}
				
			}
		}

}