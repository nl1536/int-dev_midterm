using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class gameState : MonoBehaviour
{

	public bool loseGame;

	// Use this for initialization
	void Start ()
	{

		loseGame = false;

	}
	
	// Update is called once per frame
	void Update () {

		if (loseGame == true && Input.GetKeyDown(KeyCode.Space))
		{
			SceneManager.LoadScene("New Scene");
		}
		
	}

	private void OnCollisionExit(Collision lose)
	{
		if (lose.gameObject.name == "cliff")
		{
			GameObject.FindWithTag("UIText").GetComponent<Text>().text = "you lose";
			loseGame = true;

		}
	}
}
