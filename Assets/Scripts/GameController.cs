using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {
	public static GameController gc;
	public int score;

	// Use this for initialization
	void Start () {
		gc = this;
		score = 0;
	
	}
	
	// Update is called once per frame
	
}
