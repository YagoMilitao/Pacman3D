using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class gameScript : MonoBehaviour {

	public GameObject fruit;
	public Text score;
	private int score_int = 0;

	public void incrementaScore(){ 
		fruitScript script = fruit.gameObject.GetComponent<fruitScript> ();
		score_int += 1;
		score.text = "Score: " + score_int;

	}
}
