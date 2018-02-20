using UnityEngine;
using System.Collections;
using System;

public class PopupScaleManager : MonoBehaviour {


	private Action onOpenAnimationFinishAction;
	private Action onCloseAnimationFinishAction;
	private Action<string> onCloseAnimationFinishActionInputField;

	private string button1CallBack;
	private GameObject target;
	private string callback;
	private string data;

	// Use this for initialization
	public void OnOpenAnimationPlay (Action action = null) {
		if(action != null)
			onOpenAnimationFinishAction = action;
//		iTween.ValueTo(gameObject,iTween.Hash("from",Vector3.zero,"to",new Vector3(1.1f,1.1f,1.1f),"time",0.3f,"delay",0.1f,"easetype",iTween.EaseType.easeInOutSine,"onupdate","OnValueChange","oncomplete","OnCompleteOpenAnimationStage1"));
		iTween.ValueTo(gameObject,iTween.Hash("from",new Vector3(0.5f,0.5f,0.5f),"to",new Vector3(1.1f,1.1f,1.1f),"time",0.3f,"delay",0.1f,"easetype",iTween.EaseType.easeInOutSine,"onupdate","OnValueChange","oncomplete","OnCompleteOpenAnimationStage1"));
	}

	public void OnCompleteOpenAnimationStage1 () {
		iTween.ValueTo(gameObject,iTween.Hash("from",new Vector3(1.1f,1.1f,1.1f),"to",new Vector3(1.0f,1.0f,1.0f),"time",0.2f,"easetype",iTween.EaseType.easeInOutSine,"onupdate","OnValueChange","oncomplete","OnCompleteOpenAnimation"));
	}

	public void OnCompleteOpenAnimation () {
		if(onOpenAnimationFinishAction != null)
			onOpenAnimationFinishAction();
	}





	public void OnCloseAnimationPlay (GameObject _target, string _callback, string _data) {

		target = _target;
		callback = _callback;
		data = _data;
		
		iTween.ValueTo(gameObject,iTween.Hash("from",new Vector3(1.0f,1.0f,1.0f),"to",new Vector3(1.1f,1.1f,1.1f),"time",0.2f,"delay",0.1f,"easetype",iTween.EaseType.easeInOutSine,"onupdate","OnValueChange","oncomplete","OnCompleteAnimationClose1"));
	}

	public void OnCompleteAnimationClose1() {
		iTween.ValueTo(gameObject,iTween.Hash("from",new Vector3(1.1f,1.1f,1.1f),"to",Vector3.zero,"time",0.2f,"easetype",iTween.EaseType.easeInOutSine,"onupdate","OnValueChange","oncomplete","OnCompleteCloseAnimation"));
	}

	public void OnCompleteCloseAnimation () {

		StartCoroutine ( OnCloseProcess() ) ;

	}

	IEnumerator OnCloseProcess () {

		UIAlertView.instance.Hide();

		yield return new WaitForSeconds (0.2f);
		
		if(string.IsNullOrEmpty(callback) == false) {
			if(string.IsNullOrEmpty(data) == false) {
				target.SendMessage(callback,data, SendMessageOptions.DontRequireReceiver);//transform.parent.GetComponent<CustomAlertView>().Input_Field.GetComponent<UnityEngine.UI.InputField>().text
			} else {
				target.SendMessage(callback, SendMessageOptions.DontRequireReceiver);
			}
		}

		Destroy(transform.parent.gameObject);
	}



	public void OnValueChange(Vector3 value) {
		transform.localScale = value;
	}
}
