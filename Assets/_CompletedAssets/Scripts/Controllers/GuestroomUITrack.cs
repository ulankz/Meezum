using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace MeezumGame{
public class GuestroomUITrack : UITrackable {
		[SerializeField]
		private GameObject gamePanel;
		private CanvasGroup gamePanelCanvas;
		[SerializeField]
		private GameObject cupboardPanel;
		private CanvasGroup cupboardPanelCanvas;
		[SerializeField]
		private GameObject tvPanel;
		private CanvasGroup tvPanelCanvas;

		[SerializeField]
		private GameObject optionsPanel;
		private CanvasGroup  optionsPanelCanvas;
	
	// Update is called once per frame
	void Update () {
			isHidden = (gamePanelCanvas.alpha!=1 && cupboardPanelCanvas.alpha!=1 && tvPanelCanvas.alpha!=1 && optionsPanelCanvas.alpha!=1);
	}
	public override void OnLevelLoadFinished(Scene scene,LoadSceneMode mode){
			switch(scene.name){
			case Scenes.GUEST_ROOM_SCENE:
				gamePanel = GameObject.FindGameObjectWithTag (Tags.MINI_GAME_PANEL);
				gamePanelCanvas = gamePanel.GetComponent<CanvasGroup> ();
				cupboardPanel= GameObject.FindGameObjectWithTag (Tags.CUPBOARD_PANEL);
				cupboardPanelCanvas = cupboardPanel.GetComponent<CanvasGroup> ();
				tvPanel = GameObject.FindGameObjectWithTag (Tags.TV_MIRROR_PANEL);
				tvPanelCanvas = tvPanel.GetComponent<CanvasGroup> ();
				optionsPanel = GameObject.FindGameObjectWithTag (Tags.OPTIONS_PANEL);
				optionsPanelCanvas = optionsPanel.GetComponent<CanvasGroup> ();
				break;
			default:
				
				break;
			}
		
	}
}
}