using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using MeezumGame;
public class ScoreManager : MonoBehaviour {

	public List<Sprite> digits;
	private Player player;

	void Awake() {
		//player = XMLManager.ins.playerDB.list[0];
		player = GlobalGameManager.instance.playerManager.CurrentPlayer;
		DisplayScores ();
	}

	public void UpdateScores() {
		if (player.Score < 10000) {
			player.Score += 1;
		}

		DisplayScores ();
	}

	public void DisplayScores() {
		string score = player.Score.ToString("D5");

		for (int i = 0; i < 5; i++) {
			//print ("digit_" + i.ToString());
			GameObject.Find("digit_" + i.ToString()).GetComponent<SpriteRenderer>().sprite=digits[(int)(score[4-i]-'0')];
		}
	}
}
