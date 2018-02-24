using UnityEngine;
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	void Start () {
	
		print ("Welcome to Number Wizard");
		print ("Pick a number in your head, but don't tell me");
		
		min = 1;
		max = 1000;
		print ("The highest number you can pick is " + max);
		print ("The lowest number you can pick is " + min);
		
		guess = Random.Range (min,max+1);
		
		print ("Is your number lower or higher than " + guess + " ?");
		print ("Press down arrow for lower, up arrow for higher and enter for equal");
		max = max + 1;
	}
	

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown(KeyCode.UpArrow)){
			min = guess;
			NextGuess ();
		}else if (Input.GetKeyDown(KeyCode.DownArrow)){
			max = guess;
			NextGuess();
		}else if (Input.GetKeyDown(KeyCode.Return)){
			print ("I won!");
			print ("=========================================");
			Start ();
		}
	}
	void NextGuess(){
		guess = (max + min) / 2;
		
		print ("Is the number higher or lower than " + guess + " ?");
		print ("Press down arrow for lower, up arrow for higher and enter for equal");
		
	}
}