using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GameController : MonoBehaviour {
	public static GameController gc;
	AudioSource soundTrack;
	public int score;

	// Use this for initialization
	void Start () {
		gc = this;
		score = 0;
		soundTrack = GetComponent<AudioSource> ();

	
	}

	void Update(){
		if (!soundTrack.isPlaying) {
			GameOver();
		}
	}

	void Reload(){
		Application.LoadLevel(Application.loadedLevel);
	}

	public void GameOver(){
		if (score >= 1000) {
			Result.resultDisplay.DisplayResult(true);

		} else {
			Result.resultDisplay.DisplayResult(false);
		}
		Invoke ("Reload", 10);
	}
	
	// Update is called once per frame
	
}
