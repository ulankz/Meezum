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
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
			isHidden = (!missionsPanel.activeSelf && !optionsPanel.activeSelf);
	}
}
}