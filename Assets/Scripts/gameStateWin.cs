using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameStateWin : MonoBehaviour {

public bool winGame;

	// Use this for initialization
	void Start () {
	
	winGame = false;
		
	}
	
	// Update is called once per frame
	void Update () {

		if (winGame == true && Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("New Scene");
		}
		
	}

	private void OnTriggerEnter(Collider win)
	{
		if (win.gameObject.name == "DogHouse")
		{
			GameObject.FindWithTag("UIText").GetComponent<Text>().text = "you win";
			winGame = true;
		}
	}
}
