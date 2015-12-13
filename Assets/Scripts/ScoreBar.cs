using UnityEngine;
using System.Collections;

public class ScoreBar : MonoBehaviour {
	public float scaleX;

	// Use this for initialization
	void Start(){
		scaleX = 1;
	}
	// Update is called once per frame
	void Update () {
		scaleX = (1000f - GameController.gc.score) / 1000;
		if (scaleX >= 0){
			transform.localScale = new Vector3(scaleX,1,1);
		}

	
	}
}
