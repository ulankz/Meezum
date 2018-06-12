using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame{
	public class ForestUITrack : UITrackable {

	[SerializeField]
	private GameObject missionsPanel;
	[SerializeField]
	private GameObject optionsPanel;
	// Use this for initialization
	[SerializeField]
	private CanvasGroup optionsPanelCanvas;
	private CanvasGroup missionsPanelcanvas;
	void Start () {
		optionsPanelCanvas = optionsPanel.GetComponent<CanvasGroup> ();
		missionsPanelcanvas = missionsPanel.GetComponent<CanvasGroup> ();
	}
	
	// Update is called once per frame
	void Update () {
			isHidden = (missionsPanelcanvas.alpha!=1 && optionsPanelCanvas.alpha != 1);
	}
}
}