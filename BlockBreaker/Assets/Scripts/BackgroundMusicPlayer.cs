using UnityEngine;
using System.Collections;

public class BackgroundMusicPlayer : MonoBehaviour {
	
	static BackgroundMusicPlayer instance = null; 
	
	void Awake(){
		if (instance != null) {
			Destroy (gameObject);
			print ("Duplicate destroyed");
		} else {
			instance = this;
			GameObject.DontDestroyOnLoad(gameObject);
		}
	}

	// Update is called once per frame
	void Update () {
	
	}
}
