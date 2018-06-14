using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.EventSystems; 
using MeezumGame;
public class InteractableSprite : MonoBehaviour,IPointerClickHandler,IPointerEnterHandler,IPointerExitHandler {
	[SerializeField]
	private Sprite onHighlighted;
	[SerializeField]
	private Sprite onPressed;

	public Sprite onDisabled;

	[SerializeField]
	private SpriteRenderer sRenderer;
	[SerializeField]
	private UnityEvent onMouseDown; 
	[SerializeField]
	private UnityEvent onMouseEnter;
	[SerializeField]
	private UnityEvent onMouseExit;
	//private InteractiveSpriteTracker movableGO;
	// Use this for initialization
	[SerializeField]
	private bool swapSprites = true;
	[SerializeField]
	private ActivatePanel activatePanel;
	void Start () {
		sRenderer = GetComponent<SpriteRenderer> ();
		addPhysics2DRaycaster ();
		//movableGO = GameObject.FindGameObjectWithTag(Tags.MOVABLE_OBJECT).GetComponent<InteractiveSpriteTracker>();
		activatePanel = gameObject.GetComponent<ActivatePanel>();
	}
	/*void OnMouseEnter(){
		//if (IsPointerOverGameObject()) return;
			sRenderer.sprite = onHighlighted;
			onMouseEnter.Invoke ();

	}
	void OnMouseExit(){
		//if (IsPointerOverGameObject()) return;
			sRenderer.sprite = onDisabled;
			onMouseExit.Invoke ();

	}
	void OnMouseDown(){
		//if (IsPointerOverGameObject()) return;
			sRenderer.sprite = onPressed;
			onMouseDown.Invoke ();

	}
	*/


	void addPhysics2DRaycaster()
	{
		Physics2DRaycaster physicsRaycaster = GameObject.FindObjectOfType<Physics2DRaycaster>();
		if (physicsRaycaster == null)
		{
			Camera.main.gameObject.AddComponent<Physics2DRaycaster>();
		}
	}

	public void OnPointerClick(PointerEventData eventData)
	{
		//movableGO.DeactivateColliders ();
		if(swapSprites)
		sRenderer.sprite = onPressed;
		onMouseDown.Invoke ();
		onPointerClickHandler ();
	}
	public void OnPointerEnter(PointerEventData eventData)
	{

		if(swapSprites)
		sRenderer.sprite = onHighlighted;
		onMouseEnter.Invoke ();
	}
	public void OnPointerExit(PointerEventData eventData)
	{
		if(swapSprites)
		sRenderer.sprite = onDisabled;
		onMouseExit.Invoke ();
	}

	private static bool IsPointerOverGameObject()
	{
		#if !UNITY_EDITOR && (UNITY_ANDROID || UNITY_IPHONE)
		const int fingerId = 0;
		#else
		const int fingerId = -1;
		#endif

		return EventSystem.current.IsPointerOverGameObject(fingerId);
	}
	private void onPointerClickHandler(){
		switch (gameObject.name) {
		case "Star":
			activatePanel.panelCG = GlobalGameManager.instance.Main_UI_Manager.missionsPanelCG;
		//	GlobalGameManager.instance.Main_UI_Manager.optionsButton.enabled = false;
			activatePanel.OpenPanel ();
			break;
		case "toybox":
			activatePanel.panelCG = GlobalGameManager.instance.Main_UI_Manager.miniGamePanelCG;
			activatePanel.OpenPanel ();
			break;

		case "tvmirror":
			activatePanel.panelCG = GlobalGameManager.instance.Main_UI_Manager.tvPanelCG;
			activatePanel.OpenPanel ();
			break;

		case "cupboard":
			activatePanel.panelCG = GlobalGameManager.instance.Main_UI_Manager.cupboardPanelCG;
			activatePanel.OpenPanel ();
			break;
		}


	}

}
