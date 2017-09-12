using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
	float mousePosInBlocks;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//relative mouse position with valuse between 0 and 1
		mousePosInBlocks = (Input.mousePosition.x) /Screen.width * 16;
		print (mousePosInBlocks);
	}
}
