using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class FadeTest : MonoBehaviour
{
	void Start()
	{
		gameObject.GetComponent<Graphic>().FadeOut();
	}
}

