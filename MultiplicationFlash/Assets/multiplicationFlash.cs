using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class multiplicationFlash : MonoBehaviour {
		
	public Text text1;
	public Text text2;
	public Text textCorrect;
	public Text textWrong;
	public Text userGuess;
	int number1 = 2;
	int number2 = 2;
	int answer = 0;
	int guess = 0;
	

	// Use this for initialization
		void Start () {
			number1 = Random.Range(2,15);
			number2 = Random.Range(2,15);
			answer = 0;
			guess = 0;
			StartGame ();
		}
		
		void StartGame (){
			Number1();
			Number2();
			answer = number1*number2;
		}
		
		void Guess(){
			
			if(guess!=answer){
				Wrong ();
			}else{
				Correct ();
			}	
		}
		public void Restart(){
			//number1 = 0;
			//number2 = 0;
			Start ();
		}
		void Number1(){
			text1.text = number1.ToString();
		}
		void Number2(){
			text2.text = number2.ToString();
		}
		void Wrong(){
			textWrong.text = "Wrong Try again";
		}
		void Correct(){
			textCorrect.text = "Correct! Click to try another.";
		}
		void GetInput(){
			guess = userGuess.text;
		}
}
