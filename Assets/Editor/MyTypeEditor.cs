using UnityEditor;
using UnityEngine;
using System.Collections;
using MeezumGame;
namespace GameOfWords{
[CustomEditor( typeof( GameWordsManager ) )]
public class MyTypeEditor : Editor {


	GameWordsManager m_Instance;
	PropertyField[] m_fields;


	public void OnEnable()
	{
		m_Instance = target as GameWordsManager;
		m_fields = ExposeProperties.GetProperties( m_Instance );
	}

	public override void OnInspectorGUI () {

		if ( m_Instance == null )
			return;

		this.DrawDefaultInspector();

		ExposeProperties.Expose( m_fields );

	}
}
}