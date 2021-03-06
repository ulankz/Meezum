using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeezumGame;
public class MessPeriodics_v01 : MonoBehaviour {

	public double timeOffsetInMins;
	public List<GameObject> messGameObjects;

	private List<MessElement> messItems;
	private System.DateTime nextEventTime;
	private int index=0;


	void Start () {
		nextEventTime = System.DateTime.Now.AddMinutes(timeOffsetInMins);
		//messItems = XMLManager.ins.playerDB.list[0].messItems;
		messItems = GlobalGameManager.instance.playerManager.CurrentPlayer.Disorder;
		for (int i=0; i<messItems.Count; i++) {
			if (messItems [i].Status == MessElementStatus.Disclosed) {
				ShowMessElement (i);
			}
		}
	}

	void ShowMessElement(int i) {
		if (messGameObjects [i].GetComponent<InteractWithObjectOnClick_v02> ().isTransformRequired) {
			messGameObjects [i].transform.eulerAngles = messGameObjects [i].GetComponent<InteractWithObjectOnClick_v02> ().newRotation;
		} else {
			if (messGameObjects [i].GetComponent<InteractWithObjectOnClick_v02> ().isSubstituteRequired) {
				GameObject.Find ("order" + messGameObjects [i].name.Substring (4)).GetComponent<Renderer> ().enabled = false;
			}
			if (!messGameObjects [i].GetComponent<Renderer> ().isVisible) {
				messGameObjects [i].GetComponent<Renderer> ().enabled = true;
			}
		}
	}
	
	void Update () {
		if (System.DateTime.Now.CompareTo (nextEventTime)>=0) {
			if (messItems [index].Status == MessElementStatus.Queued) {
				ShowMessElement (index);
				messItems [index].Status = MessElementStatus.Disclosed;

				if (index < messGameObjects.Count - 1)
					index += 1;
				else
					index = 0;
			} else {
				// temp (so that we do not wait when the item is not queued)
				for (int i = index; i < messItems.Count; i++) {
					if (messItems [i].Status == MessElementStatus.Queued) {
						index = i;
						break;
					}
				}
			}
				
			nextEventTime = System.DateTime.Now.AddMinutes(timeOffsetInMins);
		}
	}
}
	

