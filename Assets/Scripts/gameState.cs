﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameState : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnCollisionExit(Collision lose)
	{
		if (lose.gameObject.name == "Cliff")
		{
			GameObject.FindWithTag("UIText").GetComponent<Text>().text = "you lose";
		}
	}
}
