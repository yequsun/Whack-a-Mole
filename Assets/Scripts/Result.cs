using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Result : MonoBehaviour {
	public Text resultText;
	public static Result resultDisplay;
	// Use this for initialization
	void Start () {
		resultText = GetComponent<Text> ();
		resultText.text = "";
		resultDisplay = this;
	
	}
	
	// Update is called once per frame
	public void DisplayResult(bool result){
		if (result) {
			resultText.text = "You Win!";
		} else {
			resultText.text = "You Lose!";
		}
	}
}
