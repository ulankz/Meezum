using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

namespace Maze
{
	public class VirtualJoystick : MonoBehaviour,IDragHandler,IPointerUpHandler,IPointerDownHandler
	{
		[SerializeField]
		private Image
			bgImage;
		[SerializeField]
		private Image
			joystickImage;

		public Vector3 InputDirection{ get; set; }

		private void Start ()
		{
			bgImage = GetComponent<Image> ();	
			joystickImage = transform.GetChild (0).GetComponent<Image> ();
			InputDirection = Vector3.zero;
		}

		public virtual void OnDrag (PointerEventData eventData)
		{
			Debug.Log ("OnDrag is called");
			Vector2 pos = Vector2.zero;
			if (RectTransformUtility.ScreenPointToLocalPointInRectangle (
			bgImage.rectTransform, eventData.position, eventData.pressEventCamera, out pos)) {
				pos.x = (pos.x / bgImage.rectTransform.sizeDelta.x);// Getting the ratio where we clicked
				pos.y = (pos.y / bgImage.rectTransform.sizeDelta.y);
				float x = (bgImage.rectTransform.pivot.x == 1f) ? pos.x * 2 + 1 : pos.x * 2 - 1;
				float y = (bgImage.rectTransform.pivot.y == 1f) ? pos.y * 2 + 1 : pos.y * 2 - 1;
				InputDirection = new Vector3 (x, y, 0);
				InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;
				joystickImage.rectTransform.anchoredPosition = new Vector3 (InputDirection.x * (bgImage.rectTransform.sizeDelta.x / 3), InputDirection.y * (bgImage.rectTransform.sizeDelta.y / 3));
				Debug.Log (InputDirection);
			}
		}

		public virtual void OnPointerDown (PointerEventData eventData)
		{
			Debug.Log ("OnPointerDown is called");
			OnDrag (eventData);
		}

		public virtual void OnPointerUp (PointerEventData eventData)
		{
			Debug.Log ("OnPointerUp is called");
			InputDirection = Vector3.zero;
			joystickImage.rectTransform.anchoredPosition = Vector3.zero;
		}
	}

//			private Image jsContainer;
//			private Image joystick;
//			
//			public Vector3 InputDirection ;
//			
//			void Start(){
//				
//				jsContainer = GetComponent<Image>();
//				joystick = transform.GetChild(0).GetComponent<Image>(); //this command is used because there is only one child in hierarchy
//				InputDirection = Vector3.zero;
//			}
//			
//			public void OnDrag(PointerEventData ped){
//				Vector2 position = Vector2.zero;
//				
//				//To get InputDirection
//				RectTransformUtility.ScreenPointToLocalPointInRectangle
//					(jsContainer.rectTransform, 
//					 ped.position,
//					 ped.pressEventCamera,
//					 out position);
//				
//				position.x = (position.x/jsContainer.rectTransform.sizeDelta.x);
//				position.y = (position.y/jsContainer.rectTransform.sizeDelta.y);
//				
//				float x = (jsContainer.rectTransform.pivot.x == 1f) ? position.x *2 + 1 : position.x *2 - 1;
//				float y = (jsContainer.rectTransform.pivot.y == 1f) ? position.y *2 + 1 : position.y *2 - 1;
//				
//				InputDirection = new Vector3 (x,y,0);
//				InputDirection = (InputDirection.magnitude > 1) ? InputDirection.normalized : InputDirection;
//				
//				//to define the area in which joystick can move around
//				joystick.rectTransform.anchoredPosition = new Vector3 (InputDirection.x * (jsContainer.rectTransform.sizeDelta.x/3)
//				                                                       ,InputDirection.y * (jsContainer.rectTransform.sizeDelta.y)/3);
//				
//			}
//			
//			public void OnPointerDown(PointerEventData ped){
//				
//				OnDrag(ped);
//			}
//			
//			public void OnPointerUp(PointerEventData ped){
//				
//				InputDirection = Vector3.zero;
//				joystick.rectTransform.anchoredPosition = Vector3.zero;
//			}
//		}

}