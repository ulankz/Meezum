using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace MeezumGame{
public class GlobalGameManager : MonoBehaviour {
		#region PRIVATE MEMBERS
		[SerializeField]
		private PlayerManager playerManager;
		[SerializeField]
		private MissionManager missionManager;
		[SerializeField]
		private Stack<UIManagable> uiManagerStack;

		#endregion
}
}
