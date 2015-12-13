using UnityEngine;
using System.Collections;

public class Mole : MonoBehaviour {

	public GameObject onHit;
	public AudioSource[] soundfxs;
	int soundfxIndex;
	private AudioSource soundfx;
	bool clickable;

	// Use this for initialization
	void Start () {
		soundfxs = GetComponents<AudioSource> ();
		soundfxIndex = Random.Range (0, soundfxs.Length);
		soundfx = soundfxs [soundfxIndex];
		clickable = true;
	
	}

	void OnMouseDown(){
		if (clickable) {
			GameObject g = (GameObject)Instantiate(onHit, transform.position, Quaternion.identity);
			
			GameController.gc.score += 10;
			soundfx.Play ();
			Destroy(g, 0.2f);
			clickable = false;
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
