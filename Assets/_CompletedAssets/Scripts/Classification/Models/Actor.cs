using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using UnityEngine.EventSystems;
using UnityEngine.Events;
namespace Classification
{
	[Serializable]
	public class Actor : MonoBehaviour
	{
	#region PRIVATE MEMBERS
		[SerializeField]
		private int id;
		[SerializeField]
		private int index;
		[SerializeField]
		private string title;
		[SerializeField]
		private bool selected;
		[SerializeField]
		private ActorTypes type;
		private SpriteRenderer sRenderer;
		public delegate void OnActorSelectedDelegate (Actor actor);
		public  event OnActorSelectedDelegate onActorSelected;
		public delegate void OnActorDeselectedDelegate (Actor actor);
		public  event OnActorDeselectedDelegate onActorDeselected;

	#endregion
	#region PUBLIC PROPERTIES
		public int Index {
			get {
				return this.index;
			}
			set {
				index = value;
			}
		}
		public int Id {
			get {
				return this.id;
			}
			set {
				id = value;
			}
		}
		public string Title {
			get {
				return this.title;
			}
			set {
				title = value;
			}
		}
		public bool Selected {
			get {
				return this.selected;
			}
			set {
				selected = value;
				if(selected){
					sRenderer.color = Color.grey;
					if(onActorSelected!= null){
						onActorSelected(this);
					}
				}
				else{
					sRenderer.color = Color.white;
					if(onActorDeselected!= null){
						onActorDeselected(this);
					}
				}
			}
		}
		public ActorTypes Type{
			get{
				return this.type;
			}
			set{
				type = value;
			}
		}
	#endregion
	#region PUBLIC METHODS
		public void UpdateActor(ClassificationQuestion question,List<Sprite> sprites){
			id = question.ActorIds [index];
			type = (ActorTypes)(question.ActorIds [index]-1); // question.Actors [id]-1 because actor ids start from 1..10
			title = type.ToString();
			sRenderer.sprite = sprites [question.ActorIds [index] - 1] as Sprite;

		}
		public void SetDefaultState ()
		{
			sRenderer.color = Color.white;
		}
		public void SetCorrectChoiceState ()
		{
			sRenderer.color = Color.green;
		}
		public void SetWrongChoiceState ()
		{
			sRenderer.color = Color.red;
		}
	#endregion
	#region PRIVATE METHODS
		void Awake(){
			sRenderer = GetComponent<SpriteRenderer> ();
			index =  int.Parse(transform.name.Substring (6));
		}
		void OnMouseDown() {
			Debug.Log ("SPRITE WITH ID " + index + " IS CLICKED");
			if (Selected) 
				Selected = false;
			 else
				Selected = true;
		}
	#endregion
	}
}
