using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameStateWin : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionEnter(Collision win)
	{
		if (win.gameObject.name == "DogHouse")
		{
			GameObject.FindWithTag("UIText").GetComponent<Text>().text = "you win";
		}
	}
}
