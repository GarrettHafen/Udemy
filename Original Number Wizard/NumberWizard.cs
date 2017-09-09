using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {

	// Use this for initialization	
	int max;
	int min;
	int guess;
	void Start () {
		StartGame ();
	}
	
	void StartGame (){
		max = 1000;
		min = 1;
		guess = 500;
				
		print ("===================");
		print ("Welcome to Number Wizard");
		int mrRando = 45;
		
		print ("Pick a number in your head, like " + mrRando + ", but don't tell me what it is.");
		print ("The highest number you can pick is " + max + ".");
		print ("The lowest number you can pick is " + min +  ".");
		print (" Is the number higher or lower than " + guess + "?");
		print ("Use the Up Arrow for higher, and the Down Arrow for lower and the return or enter key for equals.");
		max = max+1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)) {
			//print ("up");
			min = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.DownArrow)) {
			//print ("down");
			max = guess;
			NextGuess();
		} else if (Input.GetKeyDown(KeyCode.Return)) {
			print ("I won!!");
			StartGame ();
		}
	}
	void NextGuess (){
		guess = (max + min)/2;
		print (" Is the number higher or lower than " + guess + "?");
		print ("Up Arrow = higher, Down Arrow = lower, enter = equals.");
	}
}
