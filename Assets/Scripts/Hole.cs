using UnityEngine;
using System.Collections;

public class Hole : MonoBehaviour {

	public GameObject mole;
	public float aliveTime = 1;

	public int intervalMin = 2;
	public int intervalMax = 10;

	// Use this for initialization
	void Start () {
		Invoke("Spawn", Random.Range(intervalMin, intervalMax));
	}


	void Spawn(){
		GameObject g = (GameObject)Instantiate(mole, transform.position, Quaternion.identity);
		g.transform.localScale = this.transform.localScale;

		Destroy(g, aliveTime);

		Invoke("Spawn", Random.Range(intervalMin, intervalMax));

	}
}
