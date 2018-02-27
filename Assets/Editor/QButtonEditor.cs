using UnityEngine;
using UnityEditor;
using UnityEngine.UI;
using QuizGame;
namespace QuizGame
{
	[CustomEditor(typeof(QuizButton),true)]
	[CanEditMultipleObjects]
	public class QButtonEditor : UnityEditor.UI.ButtonEditor
	{
		SerializedProperty m_StateImagesProperty;
		SerializedProperty m_ButtonLabelProperty;
		SerializedProperty m_ButtonImageProperty;
		SerializedProperty m_OnSpriteProperty;
		SerializedProperty m_OffSpriteProperty;
		SerializedProperty m_onSingleClickActionProperty;
		SerializedProperty m_onDoubleClickActionProperty;
		SerializedProperty  m_OnTextColorsProperty;
		SerializedProperty  m_OffTextColorsProperty;

		protected override void OnEnable ()
		{
			base.OnEnable ();
			m_StateImagesProperty = serializedObject.FindProperty ("stateImages");
			m_ButtonLabelProperty = serializedObject.FindProperty ("buttonLabel");
			m_ButtonImageProperty = serializedObject.FindProperty ("buttonImage");
			m_OnSpriteProperty = serializedObject.FindProperty ("onSprite");
			m_OffSpriteProperty = serializedObject.FindProperty ("offSprite");
			m_onSingleClickActionProperty = serializedObject.FindProperty ("onSingleClickAction");
			m_onDoubleClickActionProperty = serializedObject.FindProperty ("onDoubleClickAction");
			m_OnTextColorsProperty = serializedObject.FindProperty ("onTextColor");
			m_OffTextColorsProperty = serializedObject.FindProperty ("offTextColor");
		}

		public override void OnInspectorGUI ()
		{

			//QuizButton component = (QuizButton)target;
			//base.OnInspectorGUI ();
//		component.buttonLabel = (Text)EditorGUILayout.ObjectField ("Button Label", component.buttonLabel, typeof(Text), true);
//		component.buttonImage = (Image)EditorGUILayout.ObjectField ("Button Image", component.buttonImage, typeof(Image), true);

			serializedObject.Update ();
			EditorGUILayout.Space ();

			EditorGUILayout.PropertyField (m_StateImagesProperty, true);
			EditorGUILayout.PropertyField (m_ButtonLabelProperty, true);
			EditorGUILayout.PropertyField (m_ButtonImageProperty, true);
			EditorGUILayout.PropertyField (m_OnSpriteProperty, true);
			EditorGUILayout.PropertyField (m_OnTextColorsProperty, true);
			EditorGUILayout.PropertyField (m_OffSpriteProperty, true);
			EditorGUILayout.PropertyField (m_OffTextColorsProperty, true);

			EditorGUILayout.PropertyField (m_onSingleClickActionProperty, true);
			EditorGUILayout.PropertyField (m_onDoubleClickActionProperty, true);

			serializedObject.ApplyModifiedProperties ();



		}
			
	}

}
