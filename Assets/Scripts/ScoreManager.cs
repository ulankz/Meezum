using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour {

	public List<Sprite> digits;
	private PlayerEntry player;

	void Awake() {
		player = XMLManager.ins.playerDB.list[0];
		DisplayScores ();
	}
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void UpdateScores() {
		if (player.scores < 10000) {
			player.scores += 1;
		}

		DisplayScores ();
	}

	public void DisplayScores() {
		string score = player.scores.ToString("D5");

		for (int i = 0; i < 5; i++) {
			//print ("digit_" + i.ToString());
			GameObject.Find("digit_" + i.ToString()).GetComponent<SpriteRenderer>().sprite=digits[(int)(score[4-i]-'0')];
		}
	}
}
