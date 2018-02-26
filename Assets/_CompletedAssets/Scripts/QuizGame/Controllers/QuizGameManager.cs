using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace QuizGame{
public class QuizGameManager : MonoBehaviour {

	// Private Members
	[SerializeField]
	private List<Question> questions = new List<Question>();
	// UI Fields

	// Use this for initialization
	void Awake () {
		GenerateQuestions ();
	}
	void Start(){
		PopulateUIWithData (questions);
	}
	void GenerateQuestions ()
	{
		Question q1 = new Question ("Как ты поступишь, если незнакомый человек предложит пойти с ним?",new string[]{"Конечно пойду, он хочет помочь","Пойду если он добрый","Не пойду, и закричу, если он будет заставлять","Пойду, если он знает мойх родителей"},2);
		Question q2 = new Question ("Что ты сделаешь, если родители долго делают покупки?",new string[]{"Пойду искать игрушки","Буду торопить их быстрее сделать покупки","Пойду искать других детей,чтобы пойграть","Подожду и никуда от них не отойду"},3);
		Question q3 = new Question ("Как правильно держаться за маму в местах, где много людей?",new string[]{"Держаться за ее сумку","Крепко держать за ее руку","Держаться за ее одежду","Можно вообще не держаться, а только видеть"},1);
		questions.Add (q1);
		questions.Add (q2);
		questions.Add (q3);
	}
	void PopulateUIWithData(List<Question> questions){
		
	}
	public void CheckAnswer(){
		
	}
}
}