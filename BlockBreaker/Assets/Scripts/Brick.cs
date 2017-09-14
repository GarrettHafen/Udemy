using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {
	private LevelManager levelManager;
	private int timesHit;
	private bool isBreakable; 

	public Sprite[] hitSprites;
	public static int breakableCount = 0;


	// Use this for initialization
	void Start () {
		timesHit = 0;
		isBreakable = (this.tag == "Breakable");
		//Keep track of breakable bricks
		if (isBreakable) {
			breakableCount++;
		}
		levelManager = GameObject.FindObjectOfType<LevelManager> ();
	}
	void OnCollisionEnter2D (Collision2D collision) {
		if (isBreakable) {
			HandleHits ();
		}
	}
	void HandleHits(){
		timesHit++;
		int maxHits = hitSprites.Length + 1;
		if (timesHit >= maxHits) {
			DestroyBlock ();
			breakableCount--;
			levelManager.BrickDestroyed();
		} else {
			LoadSprites();
		}
	}
	void DestroyBlock(){
		print ("count = " +breakableCount);
		Destroy (gameObject);
	}
	void LoadSprites(){
		int spriteIndex = timesHit - 1;
		if(hitSprites[spriteIndex]){
			this.GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex];
      	}
  	}
}
