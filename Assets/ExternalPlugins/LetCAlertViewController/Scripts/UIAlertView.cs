using UnityEngine;
using UnityEngine.UI;
using System.Collections;
using System.Collections.Generic;
using System;

public class UIAlertView : MonoBehaviour {

	public GameObject customAlertView;
	public GameObject alertView;
	public GameObject ratingAlertView;

	public List<GameObject> active_alert_views = new List<GameObject>();

	public static UIAlertView instance;

	void Awake () {
		instance = this;
	}


	public void ShowCustomAlertView (GameObject target, Hashtable args) {
		
		ShowAlertView(customAlertView,target,args);

	}


	public void ShowSimpleAlertView (GameObject target, Hashtable args) {

		ShowAlertView(alertView,target,args);

	}


	public void ShowRatingAlertView (GameObject target, Hashtable args) {

		ShowAlertView(ratingAlertView,target,args);

	}

	public void ShowAlertView (GameObject prefab, GameObject target, Hashtable args) {


		GameObject alert_obj = Instantiate(prefab,Vector3.zero, Quaternion.identity) as GameObject;
		alert_obj.transform.SetParent(transform,false);
		AlertView alerView = alert_obj.GetComponent<AlertView>();

		alerView.ShowAlertView (target,args);

		active_alert_views.Add (alert_obj);

		ShowOverlay();

	}


	public void ShowOverlay () {
		if(active_alert_views.Count > 0)
			GetComponent<Image>().enabled = true;
		else
			GetComponent<Image>().enabled = false;
	}

	public void Hide () {

		if(active_alert_views.Count > 0) 
			active_alert_views.RemoveAt(active_alert_views.Count-1);
		
		ShowOverlay ();
		
	}

	/// <summary>
	/// Universal interface to help in the creation of Hashtables.  Especially useful for C# users.
	/// </summary>
	/// <param name="args">
	/// A <see cref="System.Object[]"/> of alternating name value pairs.  For example "time",1,"delay",2...
	/// </param>
	/// <returns>
	/// A <see cref="Hashtable"/>
	/// </returns>
	public static Hashtable Hash(params object[] args){
		Hashtable hashTable = new Hashtable(args.Length/2);
		if (args.Length %2 != 0) {
			Debug.LogError("LetC Error: Hash requires an even number of arguments!"); 
			return null;
		}else{
			int i = 0;
			while(i < args.Length - 1) {
				hashTable.Add(args[i], args[i+1]);
				i += 2;
			}
			return hashTable;
		}
	}


}
