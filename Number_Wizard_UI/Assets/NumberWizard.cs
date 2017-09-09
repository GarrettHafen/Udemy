using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization	
	int max;
	int min;
	int guess;
	int maxGuessesAllowed = 10;

	public Text text;

	void Start () {
		StartGame ();
	}
	
	void StartGame (){
		max = 1000;
		min = 1;
		NextGuess ();
		max = max+1;
	}

	public void GuessHigher(){
			min = guess;
			maxGuessesAllowed = maxGuessesAllowed - 1;
			NextGuess();
	}
	public void GuessLower(){
		max = guess;
		maxGuessesAllowed = maxGuessesAllowed - 1;
		NextGuess();
	}
	void NextGuess (){
		guess = Random.Range(min,max+1);
		text.text = guess.ToString();

		if (maxGuessesAllowed <= 0) {
			Application.LoadLevel("Win");
		}
	}
}
