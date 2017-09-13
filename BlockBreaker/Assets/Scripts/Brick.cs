using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	private LevelManager levelManager;
	public int maxHits;
	private int timesHit;
	// Use this for initialization
	void Start () {
		timesHit = 0;
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	
	// Update is called once per frame
	void Update () {

	}
	void OnCollisionEnter2D (Collision2D collision) {
		timesHit++;
		if (timesHit >= maxHits) {
			DestroyBlock();
		}
	}
	void DestroyBlock(){
		Destroy (gameObject);
	}
	//TODO delete when win is designed
	void simulateWin(){

		levelManager.LoadNextLevel ();
	}
}
