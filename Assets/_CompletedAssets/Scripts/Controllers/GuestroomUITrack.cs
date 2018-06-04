using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame{
public class GuestroomUITrack : UITrackable {
		[SerializeField]
		private GameObject gamePanel;
		[SerializeField]
		private GameObject cupboardPanel;
		[SerializeField]
		private GameObject tvPanel;
	//public GameObject optionsPanel;
	
	
	// Update is called once per frame
	void Update () {
			isHidden = (!gamePanel.activeSelf && !cupboardPanel.activeSelf && !tvPanel.activeSelf );//&& !optionsPanel.activeSelf
	}
}
}