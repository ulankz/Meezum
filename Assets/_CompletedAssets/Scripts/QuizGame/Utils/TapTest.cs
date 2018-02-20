using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class TapTest : MonoBehaviour, IPointerClickHandler
{
	int tap;
	float interval = 0.1f;
	bool readyForDoubleTap;
	public void OnPointerClick(PointerEventData eventData)
	{
		tap ++;
		
		if (tap ==1)
		{
			//do stuff
			
			StartCoroutine(DoubleTapInterval() );
		}
		
		else if (tap>1 && readyForDoubleTap)
		{
			//do stuff
			GetComponent<Image>().color = Color.red;
			Debug.Log("BUTTON IS DOUBLE TAPPED");
			tap = 0;
			StartCoroutine(Delay() );
			readyForDoubleTap = false;
		}
	}
	
	IEnumerator DoubleTapInterval()
	{  
		yield return new WaitForSeconds(interval);
		readyForDoubleTap = true;
	}
	IEnumerator Delay(){
		yield return new WaitForSeconds (0.3f);
		GetComponent<Image>().color = Color.white;
	}

}