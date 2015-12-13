using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeBar : MonoBehaviour {
	float totalTime = 110;
	float playTime;
	float scaleX;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		playTime = GameController.gc.GetComponent<AudioSource> ().time;
		scaleX = (totalTime - playTime) / totalTime;
		if (scaleX >= 0) {
			transform.localScale = new Vector3 (scaleX, 1, 1);
		}

	}
}
