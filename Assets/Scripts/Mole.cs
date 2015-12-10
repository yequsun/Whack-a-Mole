using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {

	public GameObject onHit;

	// Use this for initialization
	void Start () {
	
	}

	void OnMouseDown(){
		GameObject g = (GameObject)Instantiate(onHit, transform.position, Quaternion.identity);

		GameController.gc.score += 10;
		Destroy(g, 0.2f);
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
