using System.Collections;
using UnityEngine;

public class BringToFront : MonoBehaviour {

	void onEnable() {
		transform.SetAsLastSibling ();
	}
}
